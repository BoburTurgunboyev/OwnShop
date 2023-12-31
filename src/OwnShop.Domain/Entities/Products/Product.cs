﻿using OwnShop.Domain.Entities.Customers;
using OwnShop.Domain.Entities.Sales;
using OwnShop.Domain.Entities.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Entities.Products
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;    
        public int Price { get; set; }

        public long CostumerId {  get; set; }
        public Customer Customer { get; set; }

        public long ShopId { get; set; }
        public Shop Shop { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
