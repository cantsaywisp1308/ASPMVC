using DemoSession6_WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Controllers
{
    [Route("employee")]
    public class EmployeeController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index", new Employee());
        }


        [HttpPost]
        [Route("save")]
        [Route("")]
        public IActionResult Save(Employee employee)
        {
            if(employee.Username != null && employee.Username.Equals("abc"))
            {
                ModelState.AddModelError("Username", "Existed");
            }
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
