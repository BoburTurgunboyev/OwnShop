using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwnShop.Service.Interfaces.Vendors;

namespace OwnShop.WebApi.Controllers.VendorControllers
{
    [Route("api/[controller]")]
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
    }
}
