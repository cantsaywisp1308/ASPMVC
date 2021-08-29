using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemoSession6_WebApplication1.Helper;

namespace DemoSession6_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;

        public DemoController(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
        }

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("search1")]
        public ActionResult Search1(string keyword)
        {
            Debug.WriteLine("keyword: " + keyword);
            return View("Result");
        }

        [HttpGet]
        [Route("search2")]
        public ActionResult Search2(double min,double max)
        {
            Debug.WriteLine("Min: " + min);
            Debug.WriteLine("Max: " + max);
            return View("Result");
        }

        [HttpPost]
        [Route("search2")]
        public ActionResult Login(string username, string password)
        {
            Debug.WriteLine("Username: " + username);
            Debug.WriteLine("Password: " + password);
            return View("Result");
        }

        [HttpGet]
        [Route("signin")]
        public ActionResult SignIn()
        {

            return View("SignIn");
        }

        [HttpPost]
        [Route("signin")]
        public ActionResult SignIn(string username, string password)
        {
            if(username=="abc" && password == "123")
            {
                ViewBag.username = username;
                return View("Welcome");
            }
            else
            {
                ViewBag.msg = "Invalid";
                return View("SignIn");
            }
            
        }

        
        [Route("signin")]
        public ActionResult SignOut()
        {

            return RedirectToAction("signin", "demo");

        }


        [HttpGet]
        [Route("upload1")]
        public IActionResult Upload1()
        {
            return View("upload1");
        }

        [HttpPost]
        [Route("upload1")]
        public IActionResult Upload1(IFormFile photo)
        {
            Debug.WriteLine("File name: " + photo.FileName);
            Debug.WriteLine("File size: " + photo.Length + " bytes");
            Debug.WriteLine("File type: " + photo.ContentType);
            Debug.WriteLine("new file name: " + FileHelper.GenerateFileName(photo.ContentType));
            var path = Path.Combine(webHostEnvironment.WebRootPath, "images", FileHelper.GenerateFileName(photo.ContentType)); //thay thế photo.FileName = FileHelper.GenerateFileName(photo.ContentType)
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(fileStream);
            }
                return View("upload1");
        }

        [HttpGet]
        [Route("upload2")]
        public IActionResult Upload2()
        {
            return View("upload2");
        }

        [HttpPost]
        [Route("upload2")]
        public IActionResult Upload2(IFormFile[] photos)
        {
            foreach(var photo in photos)
            {
                Debug.WriteLine("File name: " + photo.FileName);
                Debug.WriteLine("File size: " + photo.Length + " bytes");
                Debug.WriteLine("File type: " + photo.ContentType);
                Debug.WriteLine("new file name: " + FileHelper.GenerateFileName(photo.ContentType));
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", FileHelper.GenerateFileName(photo.ContentType)); //thay thế photo.FileName = FileHelper.GenerateFileName(photo.ContentType)
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    photo.CopyTo(fileStream);
                }
            }
            return View("upload2");
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(int[] quantity)
        {
            foreach(var qt in quantity)
            {
                Debug.WriteLine(qt);
            }
            return View("upload2");
        }
    }
}
