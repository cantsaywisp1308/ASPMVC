using DemoSession14_WebApplication1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession14_WebApplication1.Areas.Admin.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private AccountService accountService;

        public LoginController(AccountService _accountService)
        {
            accountService = _accountService;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult process(string username, string password)
        {
            if (accountService.login(username, password))
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("welcome");
            }
            else
            {
                ViewBag.msg = "invalid";
                return View("index");
            }
        }

        [Route("welcome")]
        public IActionResult welcome()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View("welcome");
        }

        [Route("logout")]
        public IActionResult logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("index");
        }
    }
}
