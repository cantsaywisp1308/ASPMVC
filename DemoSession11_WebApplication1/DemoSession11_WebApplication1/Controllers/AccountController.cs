using DemoSession11_WebApplication1.Models;
using DemoSession11_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession11_WebApplication1.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private AccountService accountService;

        public AccountController(AccountService _accountService)
        {
            accountService = _accountService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.accounts = accountService.FindAll();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View("Add", new Account());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Account account)
        {
            account.Password = BCrypt.Net.BCrypt.HashString(account.Password);
            accountService.Create(account);
            return RedirectToAction("index", "account");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            accountService.Delete(id);
            return RedirectToAction("index", "account");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View("edit", accountService.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id,Account account)
        {
            var password = accountService.FindById(id).Password;
            if (!string.IsNullOrEmpty(account.Password))
            {
                password = BCrypt.Net.BCrypt.HashString(account.Password);
            }
            account.Password = password;
            accountService.Update(account);
            return RedirectToAction("index", "account");
        }
    }
}
