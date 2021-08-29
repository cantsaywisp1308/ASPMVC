using DemoSession11_WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession11_WebApplication1.Services
{
    public class ProductServiceImp : ProductService
    {
        private DatabaseContext db;

        public ProductServiceImp(DatabaseContext _db)
        {
            db = _db;
        }

        public Product Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
        }

        public Product Edit(Product product)
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return product;
        }

        public Product Find(int id)
        {
            return db.Products.Find(id);
        }

        public Product FindById(int id)
        {
            return db.Products.AsNoTracking().SingleOrDefault(p => p.Id == id);
        }

        List<Product> ProductService.FindAll()
        {
            return db.Products.ToList();
        }
    }
}
