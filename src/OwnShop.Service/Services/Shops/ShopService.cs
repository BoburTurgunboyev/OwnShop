using OwnShop.DataAccess.Interfaces.Shops;
using OwnShop.DataAccess.Repositories.Cotegories;
using OwnShop.Domain.Entities.Shops;
using OwnShop.Domain.Exceptions.Shops;
using OwnShop.Service.Dtos.Shops;
using OwnShop.Service.Interfaces.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Service.Shops
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRerpository;

        public ShopService(IShopRepository shopRepository)
        {
            this._shopRerpository = shopRepository;
        }
        public async  Task<long> CountAsync()
        {
           return await _shopRerpository.CountAsync();
        }

        public async Task<bool> CreateAsync(ShopDto dto)
        {
            Shop shop = new Shop()
            {
                Name = dto.Name,
                Address = dto.Address,
                PhoneNum = dto.PhoneNum,
            };

            int result = await  _shopRerpository.CreateAsync(shop);
            return result > 0;

        }

        public async Task<bool> DeleteAsync(long shopId)
        {
            var result = _shopRerpository.GetByIdAsync(shopId);
            if (result == null) throw new ShopNotFound();

            return  await _shopRerpository.DeleteAsync(shopId); 

           
        }

        public async Task<IList<Shop>> GetAllAsync()
        {
            return await _shopRerpository.GetAllAsync();
        }

        public async Task<Shop> GetByIdAsync(long shopId)
        {
            var result = await _shopRerpository.GetByIdAsync(shopId);
            if(result == null) throw new ShopNotFound();
            else return result;
        }

        public async Task<bool> UpdateAsync(long shopId, ShopDto dto)
        {
            var result = await _shopRerpository.GetByIdAsync(shopId);
            if( result == null) throw new ShopNotFound();

            result.Name = dto.Name;
            result.Address = dto.Address;
            result.PhoneNum = dto.PhoneNum;
            int shop = await _shopRerpository.UpdateAsync(shopId, result);

            return shop > 0;
        }
    }
}
