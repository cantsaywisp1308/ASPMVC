using DemoSession11_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession11_WebApplication1.Services
{
    public interface AccountService
    {

        public List<Account> FindAll();

        public Account Create(Account account);

        public void Delete(int id);

        public Account Find(int id);

        public Account FindById(int id);

        public Account Update(Account account);
    }
}
