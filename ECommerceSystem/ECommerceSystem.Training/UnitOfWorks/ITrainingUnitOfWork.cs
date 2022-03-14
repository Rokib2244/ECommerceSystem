using ECommerceSystem.Data;
using ECommerceSystem.Training.Entities;
using ECommerceSystem.Training.Repositories;

namespace ECommerceSystem.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork :IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}