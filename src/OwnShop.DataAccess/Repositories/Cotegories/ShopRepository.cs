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

        public Task<int> CountAsync()
        {
            return appDbContext.Shops.CountAsync();
        }

        public Task<int> CreateAsync(Shop repo)
        {
            appDbContext.Shops.Add(repo);
            return appDbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var del = await appDbContext.Shops.FirstOrDefaultAsync(x => x.Id == id);
            if (del is null)
                return false;


            appDbContext.Shops.Remove(del);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async  Task<IList<Shop>> GetAllAsync()
        {
            return appDbContext.Shops.ToList();
        }

        public async Task<Shop?> GetByIdAsync(long id)
        {
            return await appDbContext.Shops.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<int> UpdateAsync(long id, Shop repo)
        {
            appDbContext.Shops.Update(repo);
            return appDbContext.SaveChangesAsync();
        }
    }
}
