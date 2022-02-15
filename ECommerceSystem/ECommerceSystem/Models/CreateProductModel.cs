using Autofac;
using ECommerceSystem.Training.BusinessObjects;
using ECommerceSystem.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem.Models
{
    public class CreateProductModel
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        private readonly IProductService _productService;
        public CreateProductModel()
        {
            _productService = Startup.AutofacContainer.Resolve<IProductService>();
        }
        public CreateProductModel( IProductService productService)
        {
            _productService = productService;
        }

        internal void CreateProduct()
        {
            var product = new Product {
                ProductName = ProductName,
                Price = Price,
                CategoryId = CategoryId
            };
            _productService.CreateProduct(product);
        }
    }
}
