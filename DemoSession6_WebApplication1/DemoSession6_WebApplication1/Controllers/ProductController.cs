using DemoSession6_WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            var productModel = new ProductModel();
            var products = productModel.FindAll();
            ViewBag.products = products;
            return View();
        }

        [Route("searchByKeyword")]
        public IActionResult SearchByKeyword(string keyword)
        {
            var productModel = new ProductModel();
            var products = productModel.Search(keyword);
            ViewBag.products = products;
            ViewBag.key = keyword;
            return View("Index");
        }

        [Route("serachByPrice")]
        public IActionResult SearchByPrice(double min, double max)
        {
            var productModel = new ProductModel();
            var products = productModel.Search(min,max);
            ViewBag.products = products;
            ViewBag.min = min;
            ViewBag.max = max;
            return View("Index");
        }
    }
}
