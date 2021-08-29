using DemoSession9_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9_WebApplication1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private ProductService productService;

        public ProductController(ProductService _productService)
        {
            productService = _productService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.products = productService.FindAll();
            return View();
        }

        [Route("search1")]
        public IActionResult Search1(string keyword)
        {
            ViewBag.products = productService.Search(keyword);
            return View("Index");
        }

        [Route("search2")]
        public IActionResult Search2(double min, double max)
        {
            ViewBag.products = productService.Search(min,max);
            return View("Index");
        }
    }
}
