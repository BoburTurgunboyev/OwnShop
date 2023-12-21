using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwnShop.Service.Dtos.Vendors;
using OwnShop.Service.Interfaces.Vendors;

namespace OwnShop.WebApi.Controllers.VendorControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;

        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllVendor() 
        {
            var res = await _vendorService.GetAllAsync();
            return Ok(res);
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateVendor(VendorDto vendor)
        {
            var res = await _vendorService.CreateAsync(vendor);
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdVendor(int id)
        {
            var res = await _vendorService.GetByIdAsync(id);
            return Ok(res);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateVendor(long id,VendorDto vendor) 
        {
            var res = await _vendorService.UpdateAsync(id, vendor); 
            return Ok(res);

        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteVendor(long id)
        {
            var res = await _vendorService.DeleteAsync(id);
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> CountVendor()
        {
            var res = await _vendorService.CountAsync();
            return Ok(res);
        }
    }
}
