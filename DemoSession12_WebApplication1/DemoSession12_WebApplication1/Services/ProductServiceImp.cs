using DemoSession12_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.Services
{
    public class ProductServiceImp : ProductService
    {
        private DatabaseContext db;

        public ProductServiceImp(DatabaseContext _db)
        {
            db = _db;
        }

        public Product Find(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> FindFeaturedProducts(int n)
        {
            return db.Products.Where(p => p.Status && p.Featured).OrderByDescending(p => p.Id).Take(n).ToList();
        }

        public List<Product> FindNewProducts(int n)
        {
            return db.Products.Where(p => p.Status).OrderByDescending(p => p.Id).Take(n).ToList();
        }
    }
}
