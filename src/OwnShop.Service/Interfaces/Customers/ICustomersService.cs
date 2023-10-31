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
        public Task<bool> DeleateAsync(long customerId);

        public Task<bool> CountAsync();
        public Task<IList<Customer>> GetAlldAsync();

        public Task<Customer> GetByIdAsync(long customerId);
        public Task<bool> UpdateAsync(long customerId,CustomerDto dto);

    }
}
