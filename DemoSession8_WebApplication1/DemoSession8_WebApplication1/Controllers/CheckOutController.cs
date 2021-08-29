using DemoSession8_WebApplication1.Models;
using DemoSession8_WebApplication1.PayPal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession8_WebApplication1.Controllers
{
    [Route("checkout")]
    public class CheckOutController : Controller
    {
        private IConfiguration configuration;

        public CheckOutController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }


        [Route("index")]
        public IActionResult Index()
        {
            var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(i => i.Product.Price * i.Quantity);
            ViewBag.PostUrl = configuration["Paypal:PostUrl"].ToString();
            ViewBag.ReturnUrl = configuration["Paypal:ReturnUrl"].ToString();
            ViewBag.Business = configuration["Paypal:Business"].ToString();
            return View();
        }

        [Route("success")]
        public IActionResult Success(string tx)
        {
            var result = PDTHolder.Success(tx, configuration, Request);
            Debug.WriteLine("Payer Email: " + result.PayerEmail);
            Debug.WriteLine("Payer First Name: " + result.PayerFirstName);
            Debug.WriteLine("Payer Last Name: " + result.PayerLastName);
            Debug.WriteLine("Payment Fee: " + result.PaymentFee);
            return View("success");
        }
    }
}
