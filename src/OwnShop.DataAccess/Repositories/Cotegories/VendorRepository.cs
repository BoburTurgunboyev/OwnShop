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

        public Task<int> CountAsync()
        {
            return appDbContext.Vendors.CountAsync();
        }

        public Task<int> CreateAsync(Vendor repo)
        {
            appDbContext.Vendors.Add(repo);
            return appDbContext.Vendors.CountAsync();
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var del = await appDbContext.Vendors.FirstOrDefaultAsync(x => x.Id == id);
            if (del is null)
                return false;


            appDbContext.Vendors.Remove(del);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IList<Vendor>> GetAllAsync()
        {
            return appDbContext.Vendors.ToList();
        }

        public async Task<Vendor?> GetByIdAsync(long id)
        {
            return await appDbContext.Vendors.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public Task<int> UpdateAsync(long id, Vendor repo)
        {
            appDbContext.Vendors.Add(repo);
            return appDbContext.SaveChangesAsync();
        }
    }
}
