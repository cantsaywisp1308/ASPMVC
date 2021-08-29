using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession14_WebApplication1.Controllers
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

        [Route("index2")]
        public IActionResult Index2()
        {
            return View("index2");
        }


        [Route("index3")]
        public IActionResult Index3()
        {
            Debug.WriteLine("Demo Controller");
            var username = HttpContext.Items["username"].ToString();
            Debug.WriteLine("username: " + username);
            var id = HttpContext.Items["id"].ToString();
            Debug.WriteLine("id: " + id);
            return View("index3");
        }
    }
}
