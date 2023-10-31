using OwnShop.Domain.Entities.Shops;
using OwnShop.Service.Dtos.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Interfaces.Shops
{
    public interface IShopService
    {
        public Task<bool> CreateAsync(ShopDto dto);

        public Task<bool> UpdateAsync(long shopId,ShopDto dto);

        public Task<bool> DeleteAsync(long shopId);

        public Task<long> CountAsync();

        public Task<IList<Shop>> GetAllAsync();  

        public Task<Shop> GetByIdAsync(long shopId);
    }
}
