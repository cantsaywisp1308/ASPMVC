using DemoSession11_WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoSession11_WebApplication1.Services
{
    public class AccountServiceImp : AccountService
    {
        private DatabaseContext db;

        public AccountServiceImp(DatabaseContext _db)
        {
            db = _db;
        }

        public Account Create(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public void Delete(int id)
        {
            db.Accounts.Remove(db.Accounts.Find(id));
            db.SaveChanges();
        }

        public Account Find(int id)
        {
            return db.Accounts.Find(id);
        }

        public Account FindById(int id)
        {
            return db.Accounts.AsNoTracking().SingleOrDefault(a => a.Id == id);
        }

        public List<Account> FindAll()
        {
            return db.Accounts.ToList();
        }

        public Account Update(Account account)
        {
            db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return account;
        }
    }
}
