using DemoSession11_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession11_WebApplication1.Services
{
    public interface ProductService
    {

        public List<Product> FindAll();

        public Product Add(Product product);

        public void Delete(int id);

        public Product Find(int id);

        public Product FindById(int id);

        public Product Edit(Product product);
    }
}
