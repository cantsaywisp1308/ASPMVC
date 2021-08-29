using DemoSession10_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession10_WebApplication1.Services
{
    public interface ProductService
    {
        public Product Find();
        public List<Product> FindAll();
        public List<Product> Search(string keyword);

        public List<Product> SearchByPrice(string value);

        public List<string> AutoComplete(string keyword);

    }
}
