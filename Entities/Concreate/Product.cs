﻿using System;
using Core.Entities;

namespace Entities.Concreate
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public Product()
        {

        }
    }
}

