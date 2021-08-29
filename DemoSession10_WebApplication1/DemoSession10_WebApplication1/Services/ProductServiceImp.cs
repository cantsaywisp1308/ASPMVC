using DemoSession10_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession10_WebApplication1.Services
{
    public class ProductServiceImp : ProductService
    {
        public List<string> AutoComplete(string keyword)
        {
            return FindAll().Where(p => p.Name.ToLower().Contains(keyword.ToLower())).Select(p => p.Name).ToList();
        }

        public Product Find()
        {
            return new Product
            {
                Id = "Pr01",
                Name = "name 1",
                Price = 4.6
            };
        }

        public List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = "Pr01",
                Name = "Tivi 1",
                Price = 4.6
                },
                new Product
                {
                    Id = "Pr02",
                Name = "Laptop 1",
                Price = 12.1
                },
                new Product
                {
                    Id = "Pr03",
                Name = "Desktop 1",
                Price = 76
                },
                new Product
                {
                    Id = "Pr04",
                Name = "Desktop 2",
                Price = 22
                },
                new Product
                {
                    Id = "Pr05",
                Name = "Laptop 2",
                Price = 120
                },
            };
        }

        public List<Product> Search(string keyword)
        {

            return FindAll().Where(p => p.Name.Contains(keyword)).ToList();
        }

        public List<Product> SearchByPrice(string value)
        {
            if(value == "all")
            {
                return FindAll();
            }
            else
            {
                var prices = value.Split("to");
                var min = double.Parse(prices[0]);
                if (prices[1] == "above")
                {
                    return FindAll().Where(p => p.Price >= min).ToList();
                }
                else
                {
                    var max = double.Parse(prices[1]);
                    return FindAll().Where(p => p.Price >= min && p.Price <= max).ToList();

                }
            }
        }
    }
}
