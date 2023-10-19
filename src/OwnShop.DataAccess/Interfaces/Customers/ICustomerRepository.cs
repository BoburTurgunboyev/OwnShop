using OwnShop.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Interfaces.Customers
{
    public interface ICustomerRepository: IRepository<Customer, Customer>
    {

    }
}
