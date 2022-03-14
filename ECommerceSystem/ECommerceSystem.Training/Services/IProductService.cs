using ECommerceSystem.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Services
{
    public interface IProductService
    {
        IList<Product> GetAllProudcts();
        void CustomerPurchased (Product product, Customer customer);
        void CreateProduct(Product product);
        (IList<Product> records, int total, int totalDisplay) GetProducts(int pageIndex, int pageSize, string searchText, string sortText);
        Product GetProducts(int id);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
