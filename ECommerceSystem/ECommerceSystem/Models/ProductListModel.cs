using ECommerceSystem.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using ECommerceSystem.Training.BusinessObjects;

namespace ECommerceSystem.Models
{
    public class ProductListModel
    {
        private IProductService _poductService;
        public IList<Product> Products { get; set; }
        public ProductListModel()
        {
            _poductService = Startup.AutofacContainer.Resolve<IProductService>();
        }
        public ProductListModel( IProductService poductService)
        {
            _poductService = poductService;
        }
        public void LoadModelData()
        {
            Products = _poductService.GetAllProudcts();
        }
    }
}
