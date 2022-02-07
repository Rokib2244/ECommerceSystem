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
        public IActionResult ShowAllProducts()
        {
            var model = new ProductListModel();
            model.LoadModelData();
            return View(model);
        }
    }
}
