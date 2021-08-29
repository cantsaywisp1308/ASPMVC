using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession2_WebApplication.Models;
using System.Globalization;

namespace DemoSession2_WebApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Id = "acc1";
            ViewBag.Name = "Name 1";
            ViewBag.Price = 4.5;
            ViewBag.Quantity = 12;
            ViewBag.Status = true;
            ViewBag.names = new List<string>
            {
                "Name 1","Name 2","name 3","Name 4"
            };
            return View();
        }

        public IActionResult Index2()
        {
            ViewBag.product = new Product
            {
                Id = "id01",
                Name = "Name 1",
                Photo = "HaruMiou.jpg",
                Price = 4.5,
                Quantity = 14
            };
            return View("Index2");
        }

        public IActionResult Index3()
        {
            ViewBag.products = new List<Product>
            {
                new Product
                    {
                        Id = "id01",
                        Name = "Name 1",
                        Photo = "HaruMiou.jpg",
                        Price = 4.5,
                        Quantity = 14
                    },
                new Product
                    {
                        Id = "id02",
                        Name = "Name 2",
                        Photo = "HaruMiou2.jpg",
                        Price = 8.8,
                        Quantity = 21
                    },
                new Product
                    {
                        Id = "id03",
                        Name = "Name 3",
                        Photo = "HaruMiou.jpg",
                        Price = 11.2,
                        Quantity = 19
                    }
        };
            return View("Index3");
        }

        public IActionResult Index4()
        {
            var customer1 = new Customer
            {
                Id = "Cus001",
                Name = "Dragon Knight",
                Address = "Jungle"
            };

            var customer2 = new Customer
            {
                Id = "Cus002",
                Name = "Moon Knight",
                Address = "City"
            };

            var customer3 = new Customer
            {
                Id = "Cus003",
                Name = "Dark Willow",
                Address = "Mountain"
            };
            ViewBag.customers = new List<Customer>
            {
                customer1,customer2,customer3
            };

            var product1 = new Product
            {
                Id = "Pro001",
                Name = "Product 001",
                Photo = "lina_immortal.png",
                Price = 5.6,
                Quantity = 11
            };

            var product2 = new Product
            {
                Id = "Pro002",
                Name = "Product 002",
                Photo = "HaruMiou.jpg",
                Price = 5.3,
                Quantity = 22
            };

            var product3 = new Product
            {
                Id = "Pro003",
                Name = "Product 003",
                Photo = "axe_immortal.jpg",
                Price = 7.7,
                Quantity = 25
            };
            ViewBag.products = new List<Product> { product1, product2, product3 };

            var invoice1 = new Invoice
            {
                Id = "Inv001",
                Name = "Invoice 001",
                Created = DateTime.ParseExact("16/07/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Total = 12.4,
                Payment = "Cash",
                Customer = customer1,
                products = new List<Product> { product1 }
            };

            var invoice2 = new Invoice
            {
                Id = "Inv002",
                Name = "Invoice 002",
                Created = DateTime.ParseExact("15/07/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Total = 12.4,
                Payment = "Credit Card",
                Customer = customer3,
                products = new List<Product> { product1,product3 }
            };

            var invoice3 = new Invoice
            {
                Id = "Inv003",
                Name = "Invoice 003",
                Created = DateTime.ParseExact("17/07/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Total = 22.1,
                Payment = "Paypal",
                Customer = customer1,
                products = new List<Product> { product1,product2,product3 }
            };

            ViewBag.invoices = new List<Invoice> { invoice1, invoice2, invoice3 };
            return View("Index4");
        }
    }
}
