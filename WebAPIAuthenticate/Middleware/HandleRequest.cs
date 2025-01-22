using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIAuthenticate.Middleware
{
    public class HandleRequest
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<HandleRequest> _logger;
        public HandleRequest(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory?.CreateLogger<HandleRequest>() ??
            throw new ArgumentNullException(nameof(loggerFactory));
        }
        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation($"Request URL: {Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(context.Request)}");
            await this._next(context);
        }
    }

    public static class HttpRequestCustomHandler
    {
        public static IApplicationBuilder UseHttpRequestCustomHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HandleRequest>();
        }
    }
}
