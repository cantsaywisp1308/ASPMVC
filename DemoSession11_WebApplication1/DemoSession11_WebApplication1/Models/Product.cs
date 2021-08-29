using System;
using System.Collections.Generic;

#nullable disable

namespace DemoSession11_WebApplication1.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
