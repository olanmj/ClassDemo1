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
        private static List<Product> Products = new List<Product>();

        public ProductController()
        {
            if (Products.Count() == 0)
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

                Products.Add(p);
            }
        }
        public IActionResult ShowProduct(int? id)
        {
            Product p;
            if (id == null)
            {
                p = new Product
                {
                    ProductID = 100,
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Price = 750M,
                    Category = "Watersports",
                    Quantity = 3
                };
            } else
            {
                p = Products.Find(prod => prod.ProductID == id);
            }
            id = null;
            return View(p);
        }

        public IActionResult ProductList()
        {
            return View(Products);
        }

        public IActionResult EnterProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterProduct(Product p)
        {
            if (ModelState.IsValid) {
                Products.Add(p);
                return View("ShowProduct", p);
            } else
            {
                return View();
            }
        }

    }
}