using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession2_WebApplication.Models
{
    public class Invoice
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Payment { get; set; }
        public double Total { get; set; }
        public Customer Customer { get; set; }
        public List<Product> products { get; set; }
    }
}
