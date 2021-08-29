using DemoSession12_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.Services
{
    public class CategoryServiceImp : CategoryService
    {
        private DatabaseContext db;

        public CategoryServiceImp(DatabaseContext _db)
        {
            db = _db;
        }



        public List<Category> FindaAll()
        {
            return db.Categories.ToList();
        }

       
    }
}
