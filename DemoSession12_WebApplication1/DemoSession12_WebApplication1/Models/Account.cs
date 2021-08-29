using System;
using System.Collections.Generic;

#nullable disable

namespace DemoSession12_WebApplication1.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? Status { get; set; }
        public string Fullname { get; set; }
    }
}
