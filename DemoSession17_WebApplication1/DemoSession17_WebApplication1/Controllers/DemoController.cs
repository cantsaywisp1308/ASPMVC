using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession17_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="SuperAdmin")]
        [Route("index2")]
        public IActionResult Index2()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [Route("index3")]
        public IActionResult Index3()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin,Admin,Employee")]
        [Route("index4")]
        public IActionResult Index4()
        {
            return View();
        }
    }
}
