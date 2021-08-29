using DemoSession12_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private ProductService productService;

        public ProductController(ProductService _productService)
        {
            productService = _productService;
        }

        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            ViewBag.product = productService.Find(id);
            ViewBag.NewProducts = productService.FindNewProducts(6);
            return View();
        }
    }
}
