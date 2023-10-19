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
    internal class SaleRepository : ISaleRepository
    {
        private AppDbContext appDbContext;

        public SaleRepository(AppDbContext appDbContext) 
        {
            this.appDbContext = appDbContext;
        }
        public async Task<int> CountAsync()
        {
            return await appDbContext.Sales.CountAsync();
        }

        public Task<int> CreateAsync(Sale repo)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Sale>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Sale?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(long id, Sale repo)
        {
            throw new NotImplementedException();
        }
    }
}
