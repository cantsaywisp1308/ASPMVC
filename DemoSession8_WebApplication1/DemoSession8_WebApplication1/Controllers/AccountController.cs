using DemoSession8_WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession8_WebApplication1.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {

        [HttpGet]
        [Route("login")]
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            if(username=="abc" && password == "123")
            {
                HttpContext.Session.SetString("username", username);
                ViewBag.username = HttpContext.Session.GetString("username");
                return View("Welcome");
            }
            else
            {
                ViewBag.msg = "invalid";
                return View("Login");
            }
            
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login");
        }

    }
}
