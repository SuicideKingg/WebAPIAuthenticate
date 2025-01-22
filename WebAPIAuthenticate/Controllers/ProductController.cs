using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIAuthenticate.DataAccessLayer;
using WebAPIAuthenticate.Model;
using WebAPIAuthenticate.Model.Product;

namespace WebAPIAuthenticate.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 5)
        {
            if (_appDbContext.Product == null)
            {
                return NotFound(new Response() { Message = "Invalid Product", Status = "Failed" });
            }

            return await _appDbContext.Product.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        [HttpGet]
        [Route("getProduct/{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {

            if (_appDbContext.Product == null)
            {
                return NotFound(new Response() { Message = "Invalid Product", Status = "Failed" });
            }

            Product product = await _appDbContext.Product.FindAsync(id);
            if(product == null)
            {
                return NotFound(new Response() { Message = "Invalid Product", Status = "Failed" });
            }

            return product;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateProduct([FromBody] Product productModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                await _appDbContext.Product.AddAsync(productModel);
                await _appDbContext.SaveChangesAsync();
                return Ok(new Response { Message="Product Created Succesfully!", Status="Success" });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [ HttpPut]
        [Route("update/{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product productModel)
        {
            try
            {
                if(id != productModel.Id)
                {
                    return BadRequest(new Response { Message="Id Mismatch", Status="Failed" });
                }

                _appDbContext.Entry(productModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _appDbContext.SaveChangesAsync();
                return Ok(new Response { Message = "Product Updated Succesfully!", Status = "Success" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if(_appDbContext.Product == null)
            {
                return NotFound(new Response() { Message = "Invalid Product", Status = "Failed" });
            }

            try
            {
                Product product = await _appDbContext.Product.FindAsync(id);
                if(product == null)
                {
                    return NotFound(new Response() { Message = "Invalid Product", Status = "Failed" });
                }

                _appDbContext.Product.Remove(product);
                await _appDbContext.SaveChangesAsync();
                return Ok(_appDbContext.Product.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
