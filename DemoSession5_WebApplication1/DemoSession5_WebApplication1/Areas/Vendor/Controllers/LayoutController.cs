using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_WebApplication1.Areas.Vendor.Controllers
{
    [Area("vendor")]
    [Route("layout")]
    public class LayoutController : Controller
    {
        [Route("top")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("topside")]
        public IActionResult Index2()
        {
            return View("index2");
        }

        [Route("boxed")]
        public IActionResult Index3()
        {
            return View("index3");
        }

        [Route("fixedsidebar")]
        public IActionResult Index4()
        {
            return View("index4");
        }

        [Route("fixedsidebarcustom")]
        public IActionResult Index5()
        {
            return View("index5");
        }
    }
}
