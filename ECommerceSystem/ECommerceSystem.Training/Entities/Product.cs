﻿using ECommerceSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

    }
}
