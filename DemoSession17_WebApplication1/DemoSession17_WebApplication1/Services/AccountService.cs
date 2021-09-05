using DemoSession17_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoSession17_WebApplication1.Services
{
    public interface AccountService
    {
        public Account login(string username, string password);

        public IEnumerable<Claim> GetUser(Account account);
        
    }
}
