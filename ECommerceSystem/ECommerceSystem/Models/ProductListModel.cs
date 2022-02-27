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
        //public void LoadModelData()
        //{
        //    Products = _poductService.GetAllProudcts();
        //}

        internal object GetProducts(DataTablesAjaxRequestModel tablesModel)
        {
            var data = _poductService.GetProducts(
                tablesModel.PageIndex,
                tablesModel.PageSize,
                tablesModel.SearchText,
                tablesModel.GetSortText(new string[] { "ProductName", "Price", "Date", "CategoryId" })
                );

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.ProductName,
                            record.Price.ToString(),
                            record.Date.ToString(),
                            record.CategoryId.ToString(),
                            record.Id.ToString()

                        }
                           ).ToArray()

            };
        }

        internal void Delete(int id)
        {
            _poductService.DeleteProduct(id);
        }
    }
}
