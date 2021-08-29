using DemoSession11_WebApplication1.Models;
using DemoSession11_WebApplication1.Services;
using DemoSession6_WebApplication1.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession11_WebApplication1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private ProductService productService;

        private IWebHostEnvironment webHostEnvironment;

        public ProductController(ProductService _productService,IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
            productService = _productService;
        }

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.products = productService.FindAll();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add(Product product)
        {
            
            return View("add", new Product());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Product product,IFormFile file)
        {
            if(file != null)
            {
                var fileName = FileHelper.GenerateFileName(file.ContentType);
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName); //thay thế photo.FileName = FileHelper.GenerateFileName(photo.ContentType)
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    product.Photo = fileName;
                }
            }
            else
            {
                product.Photo = "no-image.jpg";
            }
            productService.Add(product);
            return RedirectToAction("index", "product");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            productService.Delete(id);
            return RedirectToAction("index","product");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View("edit", productService.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id,IFormFile photo,Product product)
        {
            var filename = productService.FindById(id).Photo;
            if (photo != null)
            {
                var fileName = FileHelper.GenerateFileName(photo.ContentType);
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName); //thay thế photo.FileName = FileHelper.GenerateFileName(photo.ContentType)
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    photo.CopyTo(fileStream);
                    product.Photo = fileName;
                }
            }
            else
            {
                product.Photo = filename;
            }
            productService.Edit(product);            
            return RedirectToAction("index","product");
        }
    }
}
