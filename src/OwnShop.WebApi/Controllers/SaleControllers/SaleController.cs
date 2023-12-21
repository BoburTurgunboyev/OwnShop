using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwnShop.Service.Dtos.Sales;
using OwnShop.Service.Interfaces.Sales;

namespace OwnShop.WebApi.Controllers.SaleControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllSale()
        {
            var result = await _saleService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateSale(SaleDto saleDto)
        {
            var result = await _saleService.CreateAsync(saleDto);
            return Ok(result);

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdSale(int id)
        {
            var res = await _saleService.GetByIdAsync(id);
            return Ok(res);
        }


        [HttpPut]

        public async ValueTask<IActionResult> UpdateSale(long id ,SaleDto saleDto)
        {
            var res = await _saleService.UpdateAsync(id, saleDto);
            return Ok(res);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteSale(long id) 
        {
            var res = await _saleService.DeleteAsync(id);
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> CountSale()
        {
            var res = await _saleService.CountAsync();  
            return Ok(res);
        }
    }
}
