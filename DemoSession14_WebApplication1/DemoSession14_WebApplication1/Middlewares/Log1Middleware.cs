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
    public class Log1Middleware
    {
        private readonly RequestDelegate _next;

        public Log1Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, AccountService accountService)
        {
            Debug.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            httpContext.Items["username"] = "acc1";
            httpContext.Items["id"] = "id01";
            Debug.WriteLine("check: " + accountService.check("acc2"));
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Log1Middleware>();
        }
    }
}
