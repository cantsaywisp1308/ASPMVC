using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.Controllers
{
    [Route("register")]
    public class RegisterController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
