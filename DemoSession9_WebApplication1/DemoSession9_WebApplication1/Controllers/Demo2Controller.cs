using DemoSession9_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9_WebApplication1.Controllers
{
    [Route("demo2")]
    public class Demo2Controller : Controller
    {
        private DemoService demoService;

        private CalculateService calculateService;

        public Demo2Controller(DemoService _demoService, CalculateService _calculateService)
        {
            demoService = _demoService;
            calculateService = _calculateService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Result1 = demoService.Hello();
            ViewBag.Result2 = demoService.Hi("DEF");
            return View();
        }
    }
}
