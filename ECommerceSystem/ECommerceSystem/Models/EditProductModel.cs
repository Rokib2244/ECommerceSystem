using Autofac;
using ECommerceSystem.Training.BusinessObjects;
using ECommerceSystem.Training.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem.Models
{
    public class EditProductModel
    {
        public int? Id { get; set; }
        [Required, MinLength(2),MaxLength(200,ErrorMessage = "Lenth should be Within 200")]
        public string ProductName { get; set; }
        [Required]
        public double? Price { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        private readonly IProductService _productService;
        public EditProductModel()
        {
            _productService = Startup.AutofacContainer.Resolve<IProductService>();
        }
        public void LoadModleData(int id)
        {
            var product = _productService.GetProducts(id);
            Id = product?.Id;
            ProductName = product?.ProductName;
            Price = product?.Price;
            Date = product?.Date;
            CategoryId = product?.CategoryId;

        }

        internal void Update()
        {
            var product = new Product {
                Id = Id.HasValue? Id.Value : 0,
                ProductName = ProductName,
                Price = Price.HasValue? Price.Value :0,
                Date = Date.HasValue? Date.Value :DateTime.MinValue,
                CategoryId = CategoryId.HasValue? CategoryId.Value:0
            };
            _productService.UpdateProduct(product);
        }
    }
}
