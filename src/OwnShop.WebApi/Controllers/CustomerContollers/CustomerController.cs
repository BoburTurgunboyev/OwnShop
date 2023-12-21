using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwnShop.Domain.Entities.Customers;
using OwnShop.Service.Dtos.Customers;
using OwnShop.Service.Interfaces.Customers;

namespace OwnShop.WebApi.Controllers.CustomerContollers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomersService _customersService;

        public CustomerController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet]
        [Authorize(Roles = "Customer")]
        public async ValueTask<IActionResult> GetAllCustomer()
        {
            var res = await _customersService.GetAlldAsync();
            return Ok(res);
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateCustomer(CustomerDto customerDto)
        {
            var res = await _customersService.CreateAsync(customerDto);
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetBIdCustomer(long id)
        {
            var result = await _customersService.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateCustomer(long id ,CustomerDto customerDto)
        {
            var res = await _customersService.UpdateCustomerAsync(id,customerDto);
            return Ok(res);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteCustomer(long id)
        {
            var res = await _customersService.DeleateAsync(id);
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> CountCustomer()
        {
            var res = await _customersService.CountAsync();
            return Ok(res);
        }
    }
}
