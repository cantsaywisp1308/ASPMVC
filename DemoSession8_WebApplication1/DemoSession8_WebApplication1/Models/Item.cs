using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession8_WebApplication1.Models
{
    public class Item
    {
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
