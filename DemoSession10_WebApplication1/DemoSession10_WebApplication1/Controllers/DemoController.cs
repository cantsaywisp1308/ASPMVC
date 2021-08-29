using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession10_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
