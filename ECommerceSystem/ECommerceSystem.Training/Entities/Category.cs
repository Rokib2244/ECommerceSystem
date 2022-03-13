using ECommerceSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Entities
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        //public List<Product> Products { get; set; }

    }
}
