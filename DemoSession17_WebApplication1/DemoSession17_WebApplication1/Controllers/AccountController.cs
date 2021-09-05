using DemoSession17_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace DemoSession17_WebApplication1.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private AccountService accountService;

        public AccountController(AccountService _accountService)
        {
            accountService = _accountService;
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username,string password)
        {
            var account = accountService.login(username, password);
            if (account != null)
            {
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(accountService.GetUser(account),
                    CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                return RedirectToAction("welcome");
            }
            else
            {
                ViewBag.msg = "Login Failed";
                return View("login");
            }

        }

        [HttpGet]
        [Route("welcome")]
        public IActionResult Welcome()
        {
            var user = User.FindFirst(ClaimTypes.Name);
            ViewBag.username = user.Value;
            return View("welcome");
        }


        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("login");
        }

        [Route("accessDenied")]
        public IActionResult AccessDenied()
        {
            return RedirectToAction("accessDenied");
        }
    }
}
