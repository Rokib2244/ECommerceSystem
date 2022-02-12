using ECommerceSystem.Training.BusinessObjects;
using ECommerceSystem.Training.Contexts;
using ECommerceSystem.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Services
{
    public class ProductService : IProductService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        public ProductService(ITrainingUnitOfWork trainingUnitOfWork)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
        }
        public IList<Product> GetAllProudcts()
        {
            var productEntities = _trainingUnitOfWork.Products.GetAll();
            var products = new List<Product>();
            foreach (var entity in productEntities)
            {
                var product = new Product()
                {
                    ProductName = entity.ProductName,
                    Price = entity.Price
                };
                products.Add(product);
            }
            return products;
        }
        public void CreateProduct(Product product)
        {
            _trainingUnitOfWork.Products.Add(
                new Entities.Product
                {
                    ProductName = product.ProductName,
                    Price = product.Price
                }                
                );
            _trainingUnitOfWork.Save();
        }
        public void CustomerPurchased( Product product, Customer customer)
        {
            var productEntity =  _trainingUnitOfWork.Products.GetById(product.Id);

            if (productEntity == null)
                throw new InvalidOperationException("Product was not found.");
            if (productEntity.CustomerPurchase == null)
                productEntity.CustomerPurchase = new List<Entities.ProductCustomers>();

            productEntity.CustomerPurchase.Add(new Entities.ProductCustomers {
                Customer = new Entities.Customer
                {
                    CustomerName = customer.CustomerName,
                    ContactNumber = customer.ContactNumber,
                    Address = customer.Address
                }
            });
            _trainingUnitOfWork.Save();
        }
    }
}
