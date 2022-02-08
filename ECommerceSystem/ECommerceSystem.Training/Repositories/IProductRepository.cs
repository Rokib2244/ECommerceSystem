using ECommerceSystem.Data;
using ECommerceSystem.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Repositories
{
   public interface IProductRepository : IRepository<Product, int>
    {
    }
}
