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
    public class Log2Middleware
    {
        private readonly RequestDelegate _next;

        public Log2Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Debug.WriteLine("Log2");
            var username = httpContext.Items["username"].ToString();
            Debug.WriteLine("username: " + username);
            var id = httpContext.Items["id"].ToString();
            Debug.WriteLine("id: " + id);

            httpContext.Items.Remove("username");

            var ip = httpContext.Connection.RemoteIpAddress.ToString();
            Debug.WriteLine("IP: " + ip);
            var url = httpContext.Request.Path.ToString();
            Debug.WriteLine("URL: " + url);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Log2MiddlewareExtensions
    {
        public static IApplicationBuilder UseLog2Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Log2Middleware>();
        }
    }
}
