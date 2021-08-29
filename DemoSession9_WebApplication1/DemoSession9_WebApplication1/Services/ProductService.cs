using DemoSession9_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9_WebApplication1.Services
{
    public interface ProductService
    {
        public List<Product> FindAll();
        public List<Product> Search(string keyword);
        public List<Product> Search(double min, double max);
    }
}
