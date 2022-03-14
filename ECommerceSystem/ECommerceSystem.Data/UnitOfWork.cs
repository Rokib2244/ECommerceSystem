using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _dbcontext;
        public UnitOfWork(DbContext dbcontext) => _dbcontext = dbcontext;
        public void Dispose() => _dbcontext?.Dispose();

        public void Save() => _dbcontext?.SaveChanges();
       

       
    }
}
