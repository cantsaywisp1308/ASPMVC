using DemoSession12_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private ProductService productService;

        public HomeController(ProductService _productService)
        {
            productService = _productService;
        }

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.FeaturedProducts = productService.FindFeaturedProducts(3);
            ViewBag.NewProducts = productService.FindNewProducts(3);
            return View();
        }

    }
}
