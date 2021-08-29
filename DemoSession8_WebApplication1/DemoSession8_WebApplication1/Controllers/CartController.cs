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
    [Route("cart")]
    public class CartController : Controller
    {
       

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {



            if (HttpContext.Session.GetString("cart") != null)
            {
                var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(i => i.Product.Price * i.Quantity);
            }

            return View();
        }


        [Route("buy/{id}")]
        public IActionResult Buy(string id)
        {
            var productModel = new ProductModel();
            var product = productModel.Find(id);
            if (HttpContext.Session.GetString("cart") == null)
            {
                var cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = product,
                    Quantity = 1
                });
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            }
            else
            {
                var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
                var index = Exist(id, cart);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Product = product,
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }

                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            }


            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(string id)
        {
            var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
            var index = Exist(id, cart);
            cart.RemoveAt(index);
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            return RedirectToAction("Index");
        }


        [HttpPost]
        [Route("update")]
        public IActionResult Update(int[] quantity)
        {

            var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantity[i];
            }
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            return RedirectToAction("Index");
        }
        
        private int Exist(string id, List<Item> cart)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }



    }
}
