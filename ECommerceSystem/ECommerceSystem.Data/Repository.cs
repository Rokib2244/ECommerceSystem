using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Data
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly DbContext _dbcontext;
        public Repository(DbContext context)
        {
            _dbcontext = context;
        }
        public void Add(T item)
        {
            _dbcontext.Set<T>().Add(item);
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            _dbcontext.Set<T>().Remove(item);
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
