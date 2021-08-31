using DemoSession16_WebApplication1.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession16_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private IConfiguration configuration;

        private IWebHostEnvironment webHostEnvironment; 

        public DemoController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
        }


        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("send")]
        public IActionResult Send(string to,string subject,string content)
        {
            var mailHelper = new MailHelper(configuration);
            if (mailHelper.Send("duykhang.trinh1308@gmail.com", to, subject, content))
            {
                ViewBag.msg = "Sent successfully";
                return View("Success");
            }
            else
            {
                ViewBag.msg = "Fail to send email";
                return View("Index");
            }
            
        }

        [HttpGet]
        [Route("index2")]
        public IActionResult Index2()
        {
            return View("Index2");
        }

        [HttpPost]
        [Route("index2")]
        public IActionResult Index2(string to, string subject, string content,IFormFile file)
        {
            string path = null;
            if(file!=null && file.Length > 0)
            {
                path = Path.Combine(webHostEnvironment.WebRootPath, "uploads", file.FileName);
                using(var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            var mailHelper = new MailHelper(configuration);
            if (mailHelper.Send("duykhang.trinh1308@gmail.com", to, subject, content,path))
            {
                ViewBag.msg = "Sent successfully";
                return View("Success");
            }
            else
            {
                ViewBag.msg = "Fail to send email";
                return View("Index2");
            }


        }

        [HttpGet]
        [Route("index3")]
        public IActionResult Index3()
        {
            return View("Index3");
        }

        [HttpPost]
        [Route("index3")]
        public IActionResult Index3(string to, string subject, string content, IFormFile[] files)
        {
            List<string> paths = null;
            if (files != null && files.Length > 0)
            {
                paths = new List<string>();

                foreach(var file in files)
                {
                    string path = Path.Combine(webHostEnvironment.WebRootPath, "Uploads", file.FileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    paths.Add(path);
                }
            }
            var mailHelper = new MailHelper(configuration);
            if (mailHelper.Send("duykhang.trinh1308@gmail.com", to, subject, content,paths))
            {
                ViewBag.msg = "Sent successfully";
                return View("Success");
            }
            else
            {
                ViewBag.msg = "Fail to send email";
                return View("Index3");
            }


        }
    }
}
