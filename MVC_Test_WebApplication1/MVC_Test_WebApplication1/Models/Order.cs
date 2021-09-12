using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_Test_WebApplication1.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreation { get; set; }
        public bool Status { get; set; }
        public string Payments { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
