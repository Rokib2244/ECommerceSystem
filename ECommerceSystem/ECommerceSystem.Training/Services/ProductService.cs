using ECommerceSystem.Common.Utilities;
using ECommerceSystem.Training.BusinessObjects;
using ECommerceSystem.Training.Contexts;
using ECommerceSystem.Training.Exceptions;
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
        private readonly IDateTimeUtility _dateTimeUtility;
        public ProductService(ITrainingUnitOfWork trainingUnitOfWork,
            IDateTimeUtility dateTimeUtility)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _dateTimeUtility = dateTimeUtility;
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
                    Price = entity.Price,
                    Date = entity.Date,
                    CategoryId = entity.CategoryId
                };
                products.Add(product);
            }
            return products;
        }
        public void CreateProduct(Product product)
        {
            if (product == null)
                throw new InvalidParameterException("Product was not provided");
            
            if (IsProductNameAlreadyUsed(product.ProductName))
                throw new DuplicateNameException("Product Name already Used");
            if (!IsValidTimeSetup(product.Date))
                throw new InvalidOperationException("Date should not be Past");
            
            _trainingUnitOfWork.Products.Add(
               new Entities.Product
               {
                   ProductName = product.ProductName,
                   Price = product.Price,
                   Date = product.Date,
                   CategoryId = product.CategoryId
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
        private bool IsProductNameAlreadyUsed(string prdoductName) =>
            _trainingUnitOfWork.Products.GetCount(x => x.ProductName == prdoductName) >0;
        private bool IsProductNameAlreadyUsed(string prdoductName, int id) =>
            _trainingUnitOfWork.Products.GetCount(x => x.ProductName == prdoductName && x.Id != id) > 0;

        private bool IsValidTimeSetup(DateTime date) =>
            date.Subtract(_dateTimeUtility.Now).Seconds > -1;

        public (IList<Product> records, int total, int totalDisplay) GetProducts(int pageIndex, int pageSize, string searchText, string sortText)
        {
           var producData =  _trainingUnitOfWork.Products.GetDynamic(
               string.IsNullOrWhiteSpace(searchText)?null: x => x.ProductName.Contains(searchText), sortText, string.Empty, pageIndex, pageSize);
            var resultData = (from product in producData.data
                          select new Product
                          {
                              Id = product.Id,
                              ProductName = product.ProductName,
                              Price = product.Price,
                              Date = product.Date,
                              CategoryId = product.CategoryId
                          }).ToList();
            return (resultData, producData.total, producData.totalDisplay);
        }

        public Product GetProducts(int id)
        {
            var product =_trainingUnitOfWork.Products.GetById(id);
            if (product == null) return null;
            return new Product
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Price = product.Price,
                Date = product.Date,
                CategoryId = product.CategoryId
            };
        }

        public void UpdateProduct(Product product)
        {
            if (product == null)
                throw new InvalidOperationException("Product was not found");

            if (IsProductNameAlreadyUsed(product.ProductName, product.Id))
                throw new InvalidOperationException("Product Name Already Used");
            var productEntity = _trainingUnitOfWork.Products.GetById(product.Id);
            if(productEntity != null)
            {
                productEntity.ProductName = product.ProductName;
                productEntity.Price = product.Price;
                productEntity.Date = product.Date;
                productEntity.CategoryId = product.CategoryId;
                _trainingUnitOfWork.Save();
            }
        }

        public void DeleteProduct(int id)
        {
            _trainingUnitOfWork.Products.Remove(id);
            _trainingUnitOfWork.Save();
        }
    }
}
