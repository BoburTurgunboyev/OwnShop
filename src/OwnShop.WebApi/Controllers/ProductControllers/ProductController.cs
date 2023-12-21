using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwnShop.DataAccess.Interfaces.Products;
using OwnShop.DataAccess.Repositories.Cotegories;
using OwnShop.Domain.Entities.Products;
using OwnShop.Service.Dtos.Products;
using OwnShop.Service.Interfaces.Products;

namespace OwnShop.WebApi.Controllers.ProductControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllProduct() 
        {
            var res = await _productService.GetAllAsync();
            return Ok(res);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateProduct(ProductDto productDto)
        {
            var res = await _productService.CreateAsync(productDto);
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetByIdProduct(int id)
        {
            var res = await _productService.GetByIdAsync(id);
            return Ok(res);
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateProduct(long id ,ProductDto productDto)
        {
            var res = await _productService.UpdateAsync(id,productDto);
            return Ok(res);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProduct(long id)
        {
            var res = await _productService.DeletePASync(id);
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> CountProduct() 
        {
            var res = await _productService.CountAsync();
            return Ok(res);
        }

    }
}
