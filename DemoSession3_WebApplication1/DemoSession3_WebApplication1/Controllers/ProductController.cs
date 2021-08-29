using DemoSession3_WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession3_WebApplication1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            var productModel = new ProductModel();
            var products = productModel.FindAll();
            ViewBag.products = products;
            return View();
        }

        [Route("details")]
        public IActionResult Details(string id)
        {
            var productModel = new ProductModel();
            var product = productModel.Find(id);
            ViewBag.product = product;
            return View("Details");
        }
    }
}
