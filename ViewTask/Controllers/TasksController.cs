using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewTask.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Greetings() 
        {
            return View();
        }

        public IActionResult Products() 
        {
            return View();
        }

        public IActionResult ProductInfo() 
        {
			Product[] products = new Product[]
			{
				new Product("Bread", 10),
				new Product("Mil", 11),
				new Product("Cheese", 140),
				new Product("Sausage", 110),
				new Product("Potato", 7),
				new Product("Banana", 23),
				new Product("Tomato", 25),
				new Product("Candy", 75),
			};


            return View("Products", products);
        }

        public IActionResult SuperMarkets() 
        {
            return View();
        }

        public IActionResult ShoppingList() 
        {
            return View();
        }

        public IActionResult ShoppingCart() 
        {
            return View();
        }
    }
}
