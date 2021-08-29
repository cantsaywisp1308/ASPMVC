using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession8_WebApplication1.Models
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
                    Id="pr01",
                    Name="Name 1",
                    Price = 4.6,
                    Photo = "iphone-12_2__3.jpg"
                },
                new Product
                {
                    Id="pr02",
                    Name="Name 2",
                    Price = 8.9,
                    Photo = "iphone-12-pro-max_1__7_1.jpg"
                },
                new Product
                {
                    Id="pr03",
                    Name="Name 3",
                    Price = 14,
                    Photo = "asus-rog-phone-5_0002_gsmarena_001.jpg"
                },
            };
        }
        public List<Product> FindAll()
        {
            return Products;
        }

        public Product Find(string id)
        {
            return Products.SingleOrDefault(p => p.Id.Equals(id));
        }
    }
}
