using DemoSession9_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace DemoSession9_WebApplication1.Services
{
    public class ProductServiceImp : ProductService
    {
        public List<Product> FindAll()
        {
            return new List<Product>{
                new Product
                {
                    Id = "pr01",
                    Name = "Desktop 1",
                    Price = 4.5,
                    Created = DateTime.ParseExact("07/08/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)
                },
                new Product
                {
                    Id = "pr02",
                    Name = "Tivi 1",
                    Price = 12.1,
                    Created = DateTime.ParseExact("05/05/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture)
                },
                new Product
                {
                    Id = "pr03",
                    Name = "Laptop 1",
                    Price = 8.9,
                    Created = DateTime.ParseExact("07/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture)
                }
            };
        }

        public List<Product> Search(string keyword)
        {
            return FindAll().Where(p => p.Name.Contains(keyword)).ToList();
        }

        public List<Product> Search(double min, double max)
        {
            return FindAll().Where(p => p.Price >= min && p.Price <= max).ToList();
        }
    }
}
