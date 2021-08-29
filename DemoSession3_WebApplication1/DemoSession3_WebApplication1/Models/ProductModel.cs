using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession3_WebApplication1.Models
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
                    Id="Pro01",
                    Name="Name 1",
                    Photo="HaruMiou.jpg",
                    Price=12.1
                },
                new Product
                {
                    Id="Pro02",
                    Name="Name 2",
                    Photo="axe_immortal.jpg",
                    Price=13.1
                },
                new Product
                {
                    Id="Pro03",
                    Name="Name 3",
                    Photo="HaruMiou2.jpg",
                    Price=12.2
                }
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
