using System;
using System.Collections.Generic;

#nullable disable

namespace DemoSession12_WebApplication1.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public bool Featured { get; set; }

        public virtual Category Category { get; set; }
    }
}
