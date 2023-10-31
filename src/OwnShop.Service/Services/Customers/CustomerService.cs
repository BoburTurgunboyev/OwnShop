using OwnShop.Domain.Entities.Customers;
using OwnShop.Service.Dtos.Customers;
using OwnShop.Service.Interfaces.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Service.Customers
{
    public class CustomerService : ICustomersService
    {
        public Task<bool> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(CustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleateAsync(long customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Customer>> GetAlldAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(long customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateAsync(long customerId, CustomerDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
