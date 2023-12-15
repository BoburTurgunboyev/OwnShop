using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Sales;
using OwnShop.Domain.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Repositories.Cotegories
{
    public class SaleRepository :ISaleRepository
    {
        private AppDbContext appDbContext;

        public SaleRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Task<int> CountAsync()
        {
            return appDbContext.Sales.CountAsync();
        }

        public Task<int> CreateAsync(Sale repo)
        {
            appDbContext.Sales.Add(repo);
            return appDbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var del = await appDbContext.Sales.FirstOrDefaultAsync(x => x.Id == id);
            if (del is null)
                return false;


            appDbContext.Sales.Remove(del);
            await appDbContext.SaveChangesAsync();
            return true;

        }

        public async Task<IList<Sale>> GetAllAsync()
        {
            return appDbContext.Sales.ToList();
        }

        public async Task<Sale?> GetByIdAsync(long id)
        {
            return await appDbContext.Sales.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(long id, Sale repo)
        {
            appDbContext.Sales.Update(repo);

            return await appDbContext.SaveChangesAsync();


        }
    }

}