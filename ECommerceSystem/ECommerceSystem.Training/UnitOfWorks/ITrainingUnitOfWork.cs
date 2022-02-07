using ECommerceSystem.Data;
using ECommerceSystem.Training.Entities;

namespace ECommerceSystem.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork :IUnitOfWork
    {
        IRepository<Product> Products { get; }
    }
}