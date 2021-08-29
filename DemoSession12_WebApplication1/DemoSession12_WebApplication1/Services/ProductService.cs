using DemoSession12_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.Services
{
    public interface ProductService
    {
        public List<Product> FindFeaturedProducts(int n);

        public List<Product> FindNewProducts(int n);

        public Product Find(int id);
    }
}
