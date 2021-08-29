using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession4_LayoutPage_WebApplication1.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Title = "News";
            return View();
        }
    }
}
