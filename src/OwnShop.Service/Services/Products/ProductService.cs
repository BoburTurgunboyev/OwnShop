using OwnShop.Domain.Entities.Products;
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
        public Task<long> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteASync(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long productId, ProductDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
