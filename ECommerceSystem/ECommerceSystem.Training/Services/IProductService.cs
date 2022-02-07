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
    }
}
