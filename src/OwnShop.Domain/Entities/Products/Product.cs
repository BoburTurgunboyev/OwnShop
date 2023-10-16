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
        public decimal Price { get; set; }
    }
}
