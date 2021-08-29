using DemoSession8_WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession8_WebApplication1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("~/")]
        [Route("")]
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            var productModel = new ProductModel();
            ViewBag.products = productModel.FindAll();
            return View();
        }

    }
}
