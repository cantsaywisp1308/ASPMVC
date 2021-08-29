using DemoSession10_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession10_WebApplication1.Controllers
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
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.products = productService.FindAll();
            return View();
        }

        [Route("searchByKeyword")]
        public IActionResult SearchByKeyword(string keyword)
        {
            if(keyword == null)
            {
                return new JsonResult(productService.FindAll());
            }
            return new JsonResult(productService.Search(keyword));
        }

        [Route("searchByPrice")]
        public IActionResult SearchByPrice(string value)
        {
            return new JsonResult(productService.SearchByPrice(value));
        }

        [Route("autocomplete")]
        public IActionResult Autocomplete(string term) //term là từ thư viện JqueryUI tự động tạo ra 
        {
            return new JsonResult(productService.AutoComplete(term));
        }
    }
}
