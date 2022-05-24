using ECommerceSystem.Areas.Models;
using ECommerceSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem.Areas.Admin.Controllers
{
    //[Area("Admin"),Authorize]
    [Area("Admin"), Authorize(Roles = "Admin")]
    //[Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowAllProducts()
        {
            //var model = new ProductListModel();
            //model.LoadModelData();
            //return View(model);
            return View();
        }

        public JsonResult GetAllProducts()
        {
            var dataTablesModel = new DataTablesAjaxRequestModel(Request);
            var model = new ProductListModel();
            var data = model.GetProducts(dataTablesModel);
            return Json(data);
        }
        public IActionResult CustomerPurchase()
        {
            var model = new CustomerPurchasedModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult CustomerPurchase(CustomerPurchasedModel model)
        {
            if (ModelState.IsValid)
            {
                model.CustomerPurchased();
            }
            return RedirectToAction(nameof(ShowAllProducts));
        }

        public IActionResult Create()
        {
            var model = new CreateProductModel();
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreateProduct();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Failed to Create Product");
                    _logger.LogError(ex, "Create Product Failed.");
                }
            }


            return View();
        }
        public IActionResult Edit(int id)
        {
            var model = new EditProductModel();
            model.LoadModleData(id);
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(EditProductModel model)
        {
            if (ModelState.IsValid)
            {
                model.Update();
            }
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var model = new ProductListModel();
            model.Delete(id);
            return RedirectToAction(nameof(ShowAllProducts));
        }
    }
}
