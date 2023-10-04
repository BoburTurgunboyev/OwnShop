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
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
    }
}
