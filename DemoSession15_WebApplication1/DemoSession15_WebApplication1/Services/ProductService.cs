using DemoSession15_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession15_WebApplication1.Services
{
    public interface ProductService
    {
        public List<Product> FindAll();
    }
}
