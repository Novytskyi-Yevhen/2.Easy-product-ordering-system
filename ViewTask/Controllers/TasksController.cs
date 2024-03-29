﻿using Microsoft.AspNetCore.Http;
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
        Product[] products = new Product[]
        {
                new Product("Bread", 10),
                new Product("Milk", 11),
                new Product("Cheese", 140),
                new Product("Sausage", 110),
                new Product("Potato", 7),
                new Product("Banana", 23),
                new Product("Tomato", 25),
                new Product("Candy", 75),
                new Product("Cola", 85),
        };

        public IActionResult Index() 
        {
            ViewBag.Products = products;

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
            return View("Products", products);
        }

        public IActionResult SuperMarkets() 
        {
            return View();
        }

        public IActionResult ShoppingList() 
        {
            Dictionary<Product, int> shoppingList = new Dictionary<Product, int>();

            shoppingList.Add(products[1], 2);
            shoppingList.Add(products[0], 2);
            shoppingList.Add(products[3], 1);
            shoppingList.Add(products[6], 5);
            shoppingList.Add(products[8], 10);

            ViewBag.Date = DateTime.Now.ToString("dd/MM/yyyy");

            return View("ShoppingList", shoppingList);
        }

        public IActionResult TimeToShop() 
        {
            return PartialView("TimeToShop");
        }

        [HttpGet]
        public IActionResult ShoppingCart() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(ShoppingOrder response) 
        {
            if (ModelState.IsValid) {
                Repository.AddResponse(response);

                return View("Confirm", response);
            }

            return View();
        }

        public ViewResult OrderConfirmed() 
        {
            return View();
        }
    }
}
