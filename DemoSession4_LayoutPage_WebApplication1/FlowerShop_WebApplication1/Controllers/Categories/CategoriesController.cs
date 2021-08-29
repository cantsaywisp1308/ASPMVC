using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop_WebApplication1.Controllers.Categories
{
    [Route("categories")]
    public class CategoriesController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("index2")]
        public IActionResult Index2()
        {
            return View("index2");
        }

        [Route("prices")]
        public IActionResult Index3()
        {
            return View("index3");
        }
    }
}
