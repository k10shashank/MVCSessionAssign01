using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCSessionAssign01.Models;

namespace MVCSessionAssign01.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> productList = new List<Product>()
        {
            new Product(){ Pid = "P001", Pname = "Colgate", Price = 35, Stock = 100},
            new Product(){ Pid = "P002", Pname = "Pepsodent", Price = 40, Stock = 150},
            new Product(){ Pid = "P003", Pname = "CloseUp", Price = 30, Stock = 75},
        };
        
        public IActionResult Index()
        {
            return View(productList);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod)
        {
            productList.Add(prod);
            return RedirectToAction("Index","Product");
        }
    }
}
