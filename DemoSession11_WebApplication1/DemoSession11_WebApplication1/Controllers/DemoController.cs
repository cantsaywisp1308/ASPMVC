using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession11_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private IConfiguration configuration;

        public DemoController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            var msg = configuration["Msg"].ToString();
            Debug.WriteLine("msg: " + msg);
            var value1 = configuration["MyConfigs:Config1"].ToString();
            var value2 = configuration["MyConfigs:Config2"].ToString();
            Debug.WriteLine("Value 1: " + value1);
            var value31 = configuration["MyConfigs:Config3:Config31"].ToString();
            Debug.WriteLine("Value31: " + value31);
            return View();
        }
    }
}
