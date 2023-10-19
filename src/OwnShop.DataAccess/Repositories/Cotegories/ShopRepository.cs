using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Shops;
using OwnShop.Domain.Entities.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Repositories.Cotegories
{
    public class ShopRepository : IShopRepository
    {
        private AppDbContext appDbContext;

        public ShopRepository(AppDbContext appDbContext) 
        {
            this.appDbContext = appDbContext;

        }
        public async Task<int> CountAsync()
        {
            return await appDbContext.Shops.CountAsync();
        }

        public Task<int> CreateAsync(Shop repo)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Shop>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Shop?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(long id, Shop repo)
        {
            throw new NotImplementedException();
        }
    }
}
