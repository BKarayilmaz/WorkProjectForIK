using InteraktifKredi.Data.Models;
using InteraktifKredi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteraktifKredi.Controllers
{
    
    public class ProductController : Controller
    {
        Context c = new Context();
        ProductRepository productRepository = new ProductRepository();
        [Route("/")]
        [Route("Urun")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(productRepository.ListData());
        }
      
        [AllowAnonymous]
        public IActionResult LikeProduct(int id)
        {
            var x = productRepository.GetData(id);
            x.LikeCount = ++x.LikeCount;
            productRepository.UpdateData(x);
            return RedirectToAction("Index");

        }
        
    }
}
