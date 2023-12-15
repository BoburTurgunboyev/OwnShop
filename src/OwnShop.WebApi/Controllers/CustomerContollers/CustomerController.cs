using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public async ValueTask<IActionResult> GetAll()
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
    }
}
