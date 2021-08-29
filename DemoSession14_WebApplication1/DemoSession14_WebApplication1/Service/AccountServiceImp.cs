using DemoSession14_WebApplication1.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession14_WebApplication1.Service
{
    public class AccountServiceImp : AccountService
    {
        private List<Account> Accounts;

        public AccountServiceImp()
        {
            Accounts = new List<Account>{
                new Account { Username="acc1",Password="123"},
                new Account{Username="acc2",Password="456"}
            };
        }
        public bool check(string username)
        {
            return username == "abc";
        }

        public bool login(string username, string password)
        {
            return Accounts.Count(a => a.Username == username && a.Password == password) > 0;
        }
    }
}
