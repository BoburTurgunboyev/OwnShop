using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Vendors;
using OwnShop.Domain.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Repositories.Cotegories
{
    public class VendorRepository : IVendorRepository
    {
        private AppDbContext appDbContext;

        public VendorRepository(AppDbContext appDbContext) 
        {
            this.appDbContext = appDbContext;   
        }

        public async Task<int> CountAsync()
        {
            return await appDbContext.Vendors.CountAsync(); 
        }

        public Task<int> CreateAsync(Vendor repo)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Vendor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Vendor?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(long id, Vendor repo)
        {
            throw new NotImplementedException();
        }
    }
}
