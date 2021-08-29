﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop_WebApplication1.Controllers.Contact
{
    [Route("contact")]
    public class ContactController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}