using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession14_WebApplication1.Service
{
    public interface AccountService
    {
        public bool check(string username);

        public bool login(string username, string password);
    }
}
