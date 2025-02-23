using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIAuthenticate.DataAccessLayer;
using WebAPIAuthenticate.Model.Authentication;

namespace WebAPIAuthenticate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<ApplicationUser> _userManager;

        public TokenController(ITokenService tokenService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("refresh")]
        public async Task<IActionResult> Refresh(TokenModel tokenApiModel)
        {
            if (tokenApiModel is null)
                return BadRequest("Invalid client request");

            string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;

            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
            var username = principal.Identity.Name; //this is mapped to the Name claim by default

            var user = await _userManager.FindByNameAsync(username);

            if (user == null || user.RefreshToken != refreshToken)
                return BadRequest("Invalid client request");
    
            if(user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                // Return OK result telling the client that the refresh token is expired. When this condition reached, the client should navigate back to login page(same thing should happen on the conditions above).
                return Ok(new
                {
                    AccessToken = string.Empty,
                    RefreshToken = string.Empty,
                    IsRefreshTokenActive = false
                });
            }

            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            user.AccessToken = newAccessToken;
            user.RefreshToken = newRefreshToken;

            // Update new token details of the current user.
            await _userManager.UpdateAsync(user);

            return Ok(new
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
                IsRefreshTokenActive = true
            });
        }

    }
}
