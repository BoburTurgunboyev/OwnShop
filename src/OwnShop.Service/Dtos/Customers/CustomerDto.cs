using OwnShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Dtos.Customers
{
    public class CustomerDto
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNum { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Password { get; set; }
        public Role Role { get; set; }

    }
}
