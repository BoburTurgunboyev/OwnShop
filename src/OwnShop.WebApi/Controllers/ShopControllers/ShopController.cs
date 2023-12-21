using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwnShop.Service.Dtos.Shops;
using OwnShop.Service.Interfaces.Shops;

namespace OwnShop.WebApi.Controllers.ShopControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopsService;

        public ShopController(IShopService shopsService)
        {
            _shopsService = shopsService;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllShop()
        {
            var res = await _shopsService.GetAllAsync();
            return Ok(res);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateShop(ShopDto shop)
        {
            var res = await _shopsService.CreateAsync(shop);
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdShop(int id)
        {
            var res = await _shopsService.GetByIdAsync(id);
            return Ok(res);
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateShop(long id,ShopDto shop)
        {
            var res = await _shopsService.UpdateAsync(id, shop);
            return Ok(res);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteShop(long id)
        {
            var res = await _shopsService.DeleteAsync(id);
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> CountShop() 
        {
            var res = await _shopsService.CountAsync();
            return Ok(res);
        }


        
    }
}
