using OwnShop.Domain.Entities.Shops;
using OwnShop.Service.Dtos.Shops;
using OwnShop.Service.Interfaces.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Service.Shops
{
    public class ShopService : IShopService
    {
        public Task<long> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(ShopDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long shopId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Shop>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Shop> GetByIdAsync(long shopId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long shopId, ShopDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
