using OwnShop.Domain.Entities.Customers;
using OwnShop.Service.Dtos.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Interfaces.Customers
{
    public interface ICustomersService
    {
        public Task<bool> CreateAsync(CustomerDto dto);
        public Task<bool> DeleateAsync(long Id);

        public Task<int> CountAsync();
        public Task<IList<Customer>> GetAlldAsync();

        public Task<Customer> GetByIdAsync(long customerId);
        public Task<bool> UpdateCustomerAsync(long customerId,CustomerDto dto);

    }
}
