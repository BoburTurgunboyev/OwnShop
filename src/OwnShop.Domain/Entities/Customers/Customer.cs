using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Entities.Customers
{
    public class Customer
    {
        public long Id { get; set; }    

        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
    }
}
