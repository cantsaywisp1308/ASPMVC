using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = "pr01",
                    Name= "Lina Immortal",
                    Photo = "lina_immortal.png",
                    Price = 4.4,
                    Created = DateTime.ParseExact("13/03/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)
                },
                new Product
                {
                    Id = "pr02",
                    Name= "Axe Immortal",
                    Photo = "axe_immortal.jpg",
                    Price = 12,
                    Created = DateTime.ParseExact("13/04/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)
                },
                new Product
                {
                    Id = "pr03",
                    Name= "Haru-Miou",
                    Photo = "HaruMiou.jpg",
                    Price = 8.6,
                    Created = DateTime.ParseExact("13/06/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)
                }
            };
        }

        public List<Product> FindAll()
        {
            return Products; 
        }

        public List<Product> Search(string keyword)
        {
            return Products.Where(p => p.Id.ToLower().Contains(keyword.ToLower()) || p.Name.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public List<Product> Search(double min, double max)
        {
            return Products.Where(p => p.Price >= min && p.Price <= max).ToList();
        }
    }
}
