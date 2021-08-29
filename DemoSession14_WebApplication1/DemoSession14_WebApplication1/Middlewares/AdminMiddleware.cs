using DemoSession14_WebApplication1.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession14_WebApplication1.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AdminMiddleware
    {
        private readonly RequestDelegate _next;

        public AdminMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, AccountService accountService)
        {
            var path = httpContext.Request.Path;
            if (path.Value.StartsWith("/admin")) {
                if (httpContext.Session.GetString("username") == null)
                {
                    httpContext.Response.Redirect("/login/index");
                }
            }
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AdminMiddlewareExtensions
    {
        public static IApplicationBuilder UseAdminMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AdminMiddleware>();
        }
    }
}
