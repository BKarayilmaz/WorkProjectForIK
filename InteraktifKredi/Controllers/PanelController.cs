using InteraktifKredi.Data;
using InteraktifKredi.Data.Models;
using InteraktifKredi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InteraktifKredi.Controllers
{
    //[AllowAnonymous]
    public class PanelController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        public IActionResult Index()
        {
            return View(productRepository.ListData());
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult AddProduct(Product prod)
        //{
        //    productRepository.AddData(prod);
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public IActionResult AddProduct(AddProduct ap)
        {
            Product p = new Product();
            if (ap.ImageUrl != null)
            {
                var extension = Path.GetExtension(ap.ImageUrl.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                ap.ImageUrl.CopyTo(stream);
                p.ImageUrl = newImageName;
            }
            p.ProductName = ap.ProductName;
            p.Price = ap.Price;
            p.Stock = ap.Stock;
            p.Description = ap.Description;

            productRepository.AddData(p);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult DeleteProduct(int id)
        {
            var x = productRepository.GetData(id);
            x.IsDeleted = true;
            productRepository.UpdateData(x);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateProduct(Product prod)
        {
            var x = productRepository.GetData(prod.ProductID);
            x.ProductName = prod.ProductName;
            x.Stock = prod.Stock;
            x.Price = prod.Price;
            x.ImageUrl = prod.ImageUrl;
            x.Description = prod.Description;

            productRepository.UpdateData(x);


            return RedirectToAction("Index");
        }
        public IActionResult GetProduct(int id)
        {
            var x = productRepository.GetData(id);

            Product p = new Product()
            {
                Stock = x.Stock,
                Price = x.Price,
                Description = x.Description,
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ImageUrl = x.ImageUrl
            };


            return View(p);
        }
    }
}
