using OwnShop.DataAccess.Interfaces.Customers;
using OwnShop.Domain.Entities.Customers;
using OwnShop.Domain.Exceptions.Customers;
using OwnShop.Domain.Exceptions.Vendors;
using OwnShop.Service.Dtos.Customers;
using OwnShop.Service.Dtos.Vendors;
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
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        public async Task<int> CountAsync()
        {
            var result = await _customerRepository.GetAllAsync();
            return result.Count;

            
        }

        public async Task<bool> CreateAsync(CustomerDto dto)
        {
            Customer customer = new Customer()
            {
                Name = dto.Name,
                PhoneNum = dto.PhoneNum,
                Address = dto.Address,
                Role = dto.Role,
                Password = dto.Password,

            };

            var result = await _customerRepository.CreateAsync(customer);
            return result > 0;
        }

        public async Task<bool> DeleateAsync(long id) { 

            var res =await _customerRepository.DeleteAsync(id);
            return res;

        }

        public async Task<IList<Customer>> GetAlldAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> GetByIdAsync(long customerId)
        {
            var result = await _customerRepository.GetByIdAsync(customerId);
            return result;
        }

        public async Task<bool> UpdateCustomerAsync(long customerId, CustomerDto dto)
        {
            var result = await _customerRepository.GetByIdAsync(customerId);
            if (result == null) throw new CustomerNotFound();


            result.Name = dto.Name;
            result.PhoneNum = dto.PhoneNum;
            result.Address = dto.Address;
            result.Role = dto.Role;
            result.Password = dto.Password;

            int customer = await _customerRepository.UpdateAsync(customerId, result);

            return customer > 0;


             

        }

     
    }
}