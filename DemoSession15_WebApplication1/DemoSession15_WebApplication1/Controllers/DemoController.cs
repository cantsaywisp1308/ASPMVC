using DemoSession15_WebApplication1.PayPal;
using DemoSession15_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession15_WebApplication1.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private ProductService productService;
        private IConfiguration configuration;

        public DemoController(ProductService _productService, IConfiguration _configuration)
        {
            configuration = _configuration;
            productService = _productService;
        }

        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.PostUrl = configuration["Paypal:PostUrl"].ToString();
            ViewBag.ReturnUrl = configuration["Paypal:ReturnUrl"].ToString();
            ViewBag.Business = configuration["Paypal:Business"].ToString();
            ViewBag.products = productService.FindAll();
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
            return View("Success");
        }
    }
}
