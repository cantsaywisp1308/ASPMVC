using DemoSession15_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession15_WebApplication1.Services
{
    public class ProductServiceImp : ProductService
    {
        public List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id="Id01",
                    Name="Laptop 1",
                    Photo="lina_immortal.png",
                    Price=1.25,
                    Quantity=10
                },
                new Product
                {
                    Id="Id03",
                    Name="Laptop 2",
                    Photo="axe_immortal.jpg",
                    Price=25,
                    Quantity=2
                },
                new Product
                {
                    Id="Id03",
                    Name="Desktop 1",
                    Photo="HaruMiou.jpg",
                    Price=11.99,
                    Quantity=5
                }
            };
        }
    }
}
