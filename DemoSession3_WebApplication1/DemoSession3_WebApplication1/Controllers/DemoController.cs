using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace DemoSession3_WebApplication1.Controllers
{
    [Route("demo")]
    [Route("def")]
    [Route("")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("index2")]
        public IActionResult Index2()
        {
            return View("index2");
        }

        [Route("index3/{id}")]
        public IActionResult Index3(int id)
        {
            Debug.WriteLine("id " + id);
            return View("index3");
        }

        [Route("index4/{id1}/{id2}")]
        public IActionResult Index4(int id1,string id2)
        {
            Debug.WriteLine("id 1: " + id1);
            Debug.WriteLine("id 2: " + id2);
            return View("index4");
        }

        [Route("index5")]
        public IActionResult Index5([FromQuery(Name ="id")]int masp) //gán id thành masp, nếu k có FromQuery sẽ k nhận dc
        {
            Debug.WriteLine("id: " + masp);
            return View("index2");
        }

        [Route("index6")]
        public IActionResult Index6(int id1, string id2) 
        {
            Debug.WriteLine("id1: " + id1);
            Debug.WriteLine("id2: " + id2);
            return View("index2");
        }
    }
}
