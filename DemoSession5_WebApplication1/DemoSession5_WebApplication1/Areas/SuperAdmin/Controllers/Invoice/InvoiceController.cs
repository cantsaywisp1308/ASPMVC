using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_WebApplication1.Areas.SuperAdmin.Controllers.Invoice
{
    [Area("superadmin")]
    [Route("superadmin/invocie")]
    public class InvoiceController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
