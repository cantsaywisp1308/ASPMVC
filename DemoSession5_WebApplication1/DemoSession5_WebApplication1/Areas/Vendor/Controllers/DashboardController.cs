using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_WebApplication1.Areas.Vendor.Controllers
{
    [Area("vendor")]
    [Route("vendor/dashboard")]
    public class DashboardController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("index2")]
        public IActionResult Index2()
        {
            return View("index2");
        }

        [Route("index3")]
        public IActionResult Index3()
        {
            return View("index3");
        }
    }
}
