using ECommerceSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowAllProducts()
        {
            var model = new ProductListModel();
            model.LoadModelData();
            return View(model);
        }
        public IActionResult CustomerPurchase()
        {
            var model = new CustomerPurchasedModel();
            return View(model);
        }
       [HttpPost]
        public IActionResult CustomerPurchase(CustomerPurchasedModel model)
        {
            if(ModelState.IsValid)
            {
                model.CustomerPurchased();
            }
            return RedirectToAction(nameof(ShowAllProducts));
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
