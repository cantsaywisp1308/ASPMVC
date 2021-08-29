using DemoSession8_WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession8_WebApplication1.Controllers
{
    [Route("demo")]
    [Route("~/")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("id", 123);
            HttpContext.Session.SetString("username", "acc1");

            var product = new Product
            {
                Id = "pr01",
                Name = "Name 1",
                Price = 5.6
            };

            HttpContext.Session.SetString("product", JsonConvert.SerializeObject(product));

            var products = new List<Product>
            {
                new Product
                {
                    Id="pr01",
                    Name="Name 1",
                    Price = 12
                },
                new Product
                {
                    Id="pr02",
                    Name="Name 2",
                    Price = 16
                },
                new Product
                {
                    Id="pr03",
                    Name="Name 3",
                    Price = 20
                }
            };

            HttpContext.Session.SetString("products",JsonConvert.SerializeObject(products));

            return View();
        }

        [Route("menu1")]
        public IActionResult Menu1()
        {
           if(HttpContext.Session.GetInt32("id") != null)
            {
                int id = HttpContext.Session.GetInt32("id").Value;
                Debug.WriteLine("ID: " + id);
            }

            //Hủy Session
            HttpContext.Session.Remove("username");
            return View("index");
        }

        [Route("menu2")]
        public IActionResult Menu2()
        {
            if (HttpContext.Session.GetInt32("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                Debug.WriteLine("Username: " + username);
            }
            else
            {
                Debug.WriteLine("Session username not existed");
            }
            return View("index");
        }

        [Route("menu3")]
        public IActionResult Menu3()
        {
            if (HttpContext.Session.GetString("product") != null)
            {
                var product =JsonConvert.DeserializeObject<Product>(HttpContext.Session.GetString("product"));
                Debug.WriteLine("product Info");
                Debug.WriteLine("ID: " + product.Id);
                Debug.WriteLine("Name: " + product.Name);
                Debug.WriteLine("Price: " + product.Price);
            }
            else
            {
                Debug.WriteLine("Session username not existed");
            }
            return View("index");
        }

        [Route("menu4")]
        public IActionResult Menu4()
        {
            if (HttpContext.Session.GetString("products") != null)
            {
                var products = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("products"));
                foreach(var product in products)
                {
                    Debug.WriteLine("product Info");
                    Debug.WriteLine("ID: " + product.Id);
                    Debug.WriteLine("Name: " + product.Name);
                    Debug.WriteLine("Price: " + product.Price);
                    Debug.WriteLine("================================");
                }
            }
            else
            {
                Debug.WriteLine("Session username not existed");
            }
            return View("index");
        }
    }
}
