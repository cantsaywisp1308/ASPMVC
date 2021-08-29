using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_WebApplication1.Areas.SuperAdmin.Controllers.Home
{
    [Area("superadmin")]
    [Route("superadmin/dashboard")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("index")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
