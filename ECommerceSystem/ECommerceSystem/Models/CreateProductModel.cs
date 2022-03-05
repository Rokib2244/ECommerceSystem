using Autofac;
using AutoMapper;
using ECommerceSystem.Training.BusinessObjects;
using ECommerceSystem.Training.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem.Models
{
    public class CreateProductModel
    {
        [Required, MinLength(2), MaxLength(200, ErrorMessage = "Lenth should be Within 200")]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int CategoryId { get; set; }

        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public CreateProductModel()
        {
            _productService = Startup.AutofacContainer.Resolve<IProductService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public CreateProductModel( IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        internal void CreateProduct()
        {
            //var product = new Product {
            //    ProductName = ProductName,
            //    Price = Price,
            //    Date = Date,
            //    CategoryId = CategoryId
            //};
            var product = _mapper.Map<Product>(this);
            _productService.CreateProduct(product);
        }
    }
}
