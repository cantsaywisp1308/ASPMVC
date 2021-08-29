using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop_WebApplication1.Controllers.Home
{
    [Route("home")]
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("~/")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}
