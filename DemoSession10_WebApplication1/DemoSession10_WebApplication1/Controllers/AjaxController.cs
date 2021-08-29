using DemoSession10_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession10_WebApplication1.Controllers
{
    [Route("ajax")]
    public class AjaxController : Controller
    {
        private ProductService productService;

        public AjaxController(ProductService _productService)
        {
            productService = _productService;
        }

        [Route("demo1")]
        public IActionResult Index()
        {
            return Content("Hello World", "text/plain");
        }

        [HttpPost]
        [Route("demo2")]
        public IActionResult Demo2()
        {
            return Content("Hi", "text/plain");
        }

        [Route("demo3")]
        public IActionResult Demo3(string name)
        {
            return Content("Hello " + name, "text/plain");
        }

        [HttpPost]
        [Route("demo4")]
        public IActionResult Demo4(string name1)
        {
            return Content("Hello " + name1, "text/plain");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username,string password)
        {

            if (username == "abc")
            {
                if (password == "123")
                {
                    return Content("Login successfully", "text/plain");
                }
            }
            return Content("Fail to login", "text/plain");
        }

        [Route("demo6")]
        public IActionResult Demo6()
        {
            return new JsonResult(productService.Find());
        }

        [Route("demo7")]
        public IActionResult Demo7()
        {
            return new JsonResult(productService.FindAll());
        }
    }


}
