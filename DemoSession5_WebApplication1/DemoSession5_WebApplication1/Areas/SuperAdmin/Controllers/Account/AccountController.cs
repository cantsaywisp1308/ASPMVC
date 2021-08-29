using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_WebApplication1.Areas.SuperAdmin.Controllers.Account
{
    [Area("superadmin")]
    [Route("superadmin/account")]
    public class AccountController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
