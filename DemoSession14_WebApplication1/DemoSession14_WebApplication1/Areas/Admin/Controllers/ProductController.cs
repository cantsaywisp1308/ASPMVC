using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession14_WebApplication1.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
