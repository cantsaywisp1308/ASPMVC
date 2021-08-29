using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_WebApplication1.Areas.Vendor.Controllers
{
    [Area("vendor")]
    [Route("chart")]
    public class ChartController : Controller
    {
        [Route("chartjs")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
