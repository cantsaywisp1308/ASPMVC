using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession4_LayoutPage_WebApplication1.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}
