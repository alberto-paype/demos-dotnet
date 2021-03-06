using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using br.com.paype.Services;

namespace br.com.paype
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            try
            {

                if (httpContext.Request.Path.Value == "/favicon.ico")
                {
                    // Favicon request, return 404
                    httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                    return _next(httpContext);
                }



                var controllerActionDescriptor = httpContext?
                                                .GetEndpoint()?
                                                .Metadata?
                                                .GetMetadata<ControllerActionDescriptor>();

                
                var controllerName = controllerActionDescriptor?.ControllerName;
                var actionName = controllerActionDescriptor?.ActionName;

                //string token = httpContext.Request.Headers["Authorization"];
                //if (!string.IsNullOrEmpty(token))
                //{
                //    JwtSecurityToken jwt = TokenService.DecodeToken(token);
                //}

                return _next(httpContext);
            } 
            catch
            {
                return _next(httpContext);
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthMiddleware>();
        }
    }
}
