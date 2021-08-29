using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession4_LayoutPage_WebApplication1.Controllers
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
