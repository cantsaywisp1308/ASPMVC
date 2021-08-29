using DemoSession9_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private DemoService demoService;

        private CalculateService calculateService;

        private RectangleService rectangleService;

        public DemoController(DemoService _demoService,CalculateService _calculateService,RectangleService _rectangleService) 
        {
            demoService = _demoService;
            calculateService = _calculateService;
            rectangleService = _rectangleService;
        }

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Result1 = demoService.Hello();
            ViewBag.Result2 = demoService.Hi("Kid");
            ViewBag.Result3 = calculateService.Add(3, 4);
            ViewBag.Result4 = calculateService.Mul(3, 4);
            ViewBag.Result5 = rectangleService.Area(2, 5);
            ViewBag.Result6 = rectangleService.Perimeter(2, 5);
            return View();
        }
    }
}
