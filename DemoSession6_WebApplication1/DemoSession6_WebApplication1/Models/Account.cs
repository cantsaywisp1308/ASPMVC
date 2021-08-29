using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

        public bool Status { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }

        public Address Address { get; set; }
        public int Id { get; set; }
        public string Photo { get; set; }
    }
}
