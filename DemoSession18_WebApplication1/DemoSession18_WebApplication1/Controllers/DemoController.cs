using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession18_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private IStringLocalizer<MyMessage> myMessage;
        
        public DemoController(IStringLocalizer<MyMessage> _myMessage)
        {
            myMessage = _myMessage;
        }


        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.price = 12345;
            ViewBag.number = 12345;
            ViewBag.percent = 1234;
            ViewBag.today = DateTime.Now;
            var msg = myMessage["Msg"];
            Debug.WriteLine(msg);
            return View();
        }
    }
}
