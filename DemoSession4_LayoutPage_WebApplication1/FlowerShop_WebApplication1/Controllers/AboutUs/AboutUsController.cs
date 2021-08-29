using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop_WebApplication1.Controllers.AboutUs
{
    [Route("aboutus")]
    public class AboutUsController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
