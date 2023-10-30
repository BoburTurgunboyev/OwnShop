using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Exceptions.Customers
{
    public class CustomerNotFound:NotFoundException
    {
        public CustomerNotFound() 
        {
            Massage = "Customer not found";
        }
    }
}
