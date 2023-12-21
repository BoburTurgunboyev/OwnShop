using OwnShop.Domain.Entities.Products;
using OwnShop.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Interfaces.Products
{
    public interface IProductService
    {
        public Task<bool> CreateAsync(ProductDto dto);
        public Task<bool> DeletePASync(long productId);


        public Task<long> CountAsync();
        public Task<bool> UpdateAsync(long productId, ProductDto dto);

        public Task<IList<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(long productId);
    }
}
