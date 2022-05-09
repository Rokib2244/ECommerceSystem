using ECommerceSystem.Membership.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Membership.Seeds
{
    public static class DataSeed
    {
        public static Role[] Roles
        {
            get
            {
                return new Role[]
                {
                    new Role{ Id = Guid.NewGuid(), Name = "Admin2", NormalizedName = "ADMIN2", ConcurrencyStamp = Guid.NewGuid().ToString()},                    
                    new Role{ Id = Guid.NewGuid(), Name = "Employee", NormalizedName = "EMPLOYEE", ConcurrencyStamp = Guid.NewGuid().ToString()}
                };
            }
        }
    }
}
