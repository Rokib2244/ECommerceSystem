using ECommerceSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Entities
{
    public class Customer : IEntity<int>
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public double ContactNumber { get; set; }
        public List<ProductCustomers> PurchasedProduct { get; set; }
    }
}
