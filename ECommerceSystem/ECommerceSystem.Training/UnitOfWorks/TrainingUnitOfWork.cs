using ECommerceSystem.Data;
using ECommerceSystem.Training.Contexts;
using ECommerceSystem.Training.Entities;
using ECommerceSystem.Training.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public IProductRepository Products { get; private set; }
        public TrainingUnitOfWork(TrainingContext context,
            IProductRepository products) : base(context)
        {
            Products = products;
        }

    }
}
