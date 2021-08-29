using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop_WebApplication1.Controllers.Accounts
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("myaccount")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Index2()
        {
            return View("index2");
        }
    }
}
