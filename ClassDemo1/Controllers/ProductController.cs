using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassDemo1.Models;

namespace ClassDemo1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowProduct()
        {
            Product p = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 750M,
                Category = "Watersports",
                Quantity = 3
            };
            return View(p);
        }

        public IActionResult EnterProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterProduct(Product p)
        {
            if (ModelState.IsValid) { 
                return View("ShowProduct", p);
            } else
            {
                return View();
            }
        }

    }
}