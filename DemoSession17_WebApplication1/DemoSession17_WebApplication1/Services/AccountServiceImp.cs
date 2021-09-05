using DemoSession17_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoSession17_WebApplication1.Services
{
    public class AccountServiceImp : AccountService
    {
        private List<Account> accounts;

        public AccountServiceImp()
        {
            accounts = new List<Account>
            {
                new Account
                {
                    Username="acc1",
                    Password = "123",
                    Roles = new List<string>{"SuperAdmin","Admin","Employee"}
                },
                new Account
                {
                    Username="acc2",
                    Password = "456",
                    Roles = new List<string>{"Admin","Employee"}
                },
                new Account
                {
                    Username="acc3",
                    Password = "789",
                    Roles = new List<string>{"Employee"}
                }
            };
        }

        public IEnumerable<Claim> GetUser(Account account)
        {

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, account.Username));
            foreach(var role in account.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;

        }

        public Account login(string username, string password)
        {
            return accounts.SingleOrDefault(a => a.Username == username && a.Password == password);
        }
    }
}
