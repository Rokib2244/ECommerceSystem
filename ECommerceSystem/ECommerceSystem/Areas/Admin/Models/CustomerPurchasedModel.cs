using Autofac;
using ECommerceSystem.Training.Services;
using ECommerceSystem.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem.Areas.Models
{
    public class CustomerPurchasedModel
    {
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        private readonly IProductService _productService;

        public CustomerPurchasedModel()
        {
            _productService = Startup.AutofacContainer.Resolve<IProductService>();
        }
        public CustomerPurchasedModel(IProductService productService)
        {
            _productService = productService;
        }

        public void CustomerPurchased( )
        {
            var products = _productService.GetAllProudcts();

            var selectedProduct = products.Where(x => x.ProductName == ProductName).FirstOrDefault();

            var customer = new Customer {
                Id = CustomerId,
                CustomerName = "Rafid",
                ContactNumber = 0189444455,
                Address = "Halishahar"                
            };
            _productService.CustomerPurchased(selectedProduct, customer);
        }

    }
}
