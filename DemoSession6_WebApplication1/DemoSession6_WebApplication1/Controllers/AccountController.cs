using DemoSession6_WebApplication1.Helper;
using DemoSession6_WebApplication1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;

        public AccountController(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
        }


        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            var account = new Account()
            {
                Username="acc1",
                Description="ABCXYZ",
                Gender="m",
                Role="r3",
                Address = new Address
                {
                    Street = "St01",
                    Ward = "W01",
                    District = "D01"
                },
                Id = 123
            };
            return View("Index",account);
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Save(Account account, IFormFile photo)
        {

            var fileName = FileHelper.GenerateFileName(photo.ContentType);
            var path = Path.Combine(webHostEnvironment.WebRootPath, "images",fileName); //thay thế photo.FileName = FileHelper.GenerateFileName(photo.ContentType)
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(fileStream);
                account.Photo = fileName;
            }

            Debug.WriteLine("Photo: " + account.Photo);
            Debug.WriteLine("username: " + account.Username);
            Debug.WriteLine("Password: " + account.Password);
            var hash = BCrypt.Net.BCrypt.HashString(account.Password);
            Debug.WriteLine("Password hash: " + hash);
            Debug.WriteLine("Description: " + account.Description);
            Debug.WriteLine("Status: " + account.Status);
            Debug.WriteLine("Gender: " + account.Gender);
            Debug.WriteLine("Role: " + account.Role);
            Debug.WriteLine("Street: " + account.Address.Street);
            Debug.WriteLine("Ward: " + account.Address.Ward);
            Debug.WriteLine("District: " + account.Address.District);
            Debug.WriteLine("Id: " + account.Id);
            return View("Success");
        }
    }
}
