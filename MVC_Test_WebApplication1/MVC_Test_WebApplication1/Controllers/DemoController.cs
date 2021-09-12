using Microsoft.AspNetCore.Mvc;
using MVC_Test_WebApplication1.Models;
using MVC_Test_WebApplication1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private CustomerService customerService;

        public DemoController(CustomerService _customerService)
        {
            customerService = _customerService;
        }
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.customers = customerService.FindAll();
            return View();
        }

        [HttpGet]
        [Route("changeProfile/{cusID}")]
        public IActionResult ChangeProfile(int cusID)
        {
            return View("changeProfile",customerService.Find(cusID));
        }

        [HttpPost]
        [Route("changeProfile/{cusID}")]
        public IActionResult ChangeProfile(int cusID,Customer customer)
        {
            customerService.ChangeProfile(customer);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("addOrder/{cusID}")]
        public IActionResult AddOrder(int cusID,Order order)
        {
            ViewBag.cusID = cusID;
            ViewBag.DateCreation = DateTime.Now;
            return View("addOrder", new Order());
        }

        [HttpPost]
        [Route("addOrder/{cusID}")]
        public IActionResult AddOrder(Order order)
        {
            order.DateCreation = DateTime.Today;
            customerService.AddNewOrder(order);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("viewOrders/{cusID}")]
        public IActionResult ViewOrders(int cusID)
        {
            ViewBag.orders = customerService.ListOrders(cusID);
            ViewBag.cusID = cusID;
            return View("viewOrders");
        }

        [Route("deleteOrder/{ordID}/{cusID}")]
        public IActionResult DeleteOrder(int ordID,int cusID)
        {
            customerService.DeleteOrder(ordID);
            ViewBag.cusID = cusID;
            return RedirectToAction("viewOrders", new {cusID = cusID}); //redirect về chính Route với CusID là chính nó
        }
    }
}
