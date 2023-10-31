using OwnShop.DataAccess.Interfaces.Products;
using OwnShop.Domain.Entities.Products;
using OwnShop.Domain.Exceptions.Products;
using OwnShop.Service.Dtos.Products;
using OwnShop.Service.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Service.Products
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
        {
            this._productRepository = productRepository;
        }
        public async Task<long> CountAsync()
        {
           return await _productRepository.CountAsync();
        }

        public async Task<bool> CreateAsync(ProductDto dto)
        {
            Product product = new Product()
            {
                Name = dto.Name,
                Price = dto.Price,

            };

            var result = await _productRepository.CreateAsync(product);

            return result > 0;
        }

        public Task<bool> DeleteASync(long productId)
        {
            var result = _productRepository.GetByIdAsync(productId);
            if (result == null) throw new ProductNotFoundException();
            
            var del =_productRepository.DeleteAsync(productId);
            return del;
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(long productId)
        {
            var result = await _productRepository.GetByIdAsync(productId);
            if (result == null) throw new ProductNotFoundException();
            else return result;
        }

        public async Task<bool> UpdateAsync(long productId, ProductDto dto)
        {
            var result = await _productRepository.GetByIdAsync(productId);
            if (result == null) throw new ProductNotFoundException();

            result.Name = dto.Name;
            result.Price = dto.Price;
            
            var product = await _productRepository.UpdateAsync(productId,result);
            return product > 0;

        }
    }
}
