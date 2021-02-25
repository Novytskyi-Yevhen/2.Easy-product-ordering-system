using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewTask.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Greetings() {
            return View();
        }

        public IActionResult Products() {
            return View();
        }

        public IActionResult ProductInfo() {
            return View();
        }

        public IActionResult SuperMarkets() {
            return View();
        }

        public IActionResult ShoppingList() {
            return View();
        }

        public IActionResult ShoppingCart() {
            return View();
        }
    }
}
