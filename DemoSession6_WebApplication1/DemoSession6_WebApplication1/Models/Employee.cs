using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Models
{
    public partial class Employee
    {
        //Set requirements for Username

        public string Username { get; set; }


        //Set requirements for passwords

        public string Password { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }
        
    }
}
