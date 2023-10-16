using OwnShop.Domain.Entities.Products;
using OwnShop.Domain.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Entities.Shops
{
    public class Shop
    {
        public long Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; }= string.Empty;
        public string PhoneNum { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; }
        public ICollection<Sale> Sales { get; set; }
       
    }
}
