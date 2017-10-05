using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClassDemo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "My first MVC app";
            DateTime today = new DateTime(2019, 12, 29, 5, 30, 0);
                // DateTime.Now;
            ViewData["Time"] = today.ToShortTimeString();
            ViewData["Date"] = today.ToShortDateString();
            return View();
        }

        public IActionResult About(int id)
        {
            ViewData["Count"] = id;
            return View();
        }

        public IActionResult Items()
        {
            int[] items = { 123, 652, 13, 94, 500, 76 };
            return View(items);
        }
    }
}