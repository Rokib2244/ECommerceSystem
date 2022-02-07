using ECommerceSystem.Data;
using ECommerceSystem.Training.Contexts;
using ECommerceSystem.Training.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(TrainingContext context):base(context)
        {

        }
        
    }
}
