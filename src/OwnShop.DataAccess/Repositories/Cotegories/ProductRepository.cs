using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Products;
using OwnShop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Repositories.Cotegories
{
    public class ProductRepository : IProductRepository
    {
        private AppDbContext appDbContext;

        public ProductRepository(AppDbContext appDbContext) 
        {
            this.appDbContext = appDbContext;
        }

        public async Task<int> CountAsync()
        {
            return await appDbContext.Products.CountAsync();    
        }

        public async Task<int> CreateAsync(Product repo)
        {
            await appDbContext.Products.AddAsync(repo);
            return  appDbContext.SaveChanges();
        }

        public async Task<bool> DeleteAsync(long id)
        {
          var del = await appDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if(del is  null)
            return false;

            appDbContext.Products.Remove(del);  
            await appDbContext.SaveChangesAsync();
            return true;
            
            
        }

        public async Task<IList<Product>> GetAllAsync()
        {
           return await appDbContext.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(long id)
        {
            return await appDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<int> UpdateAsync(long id, Product repo)
        {
            appDbContext.Products.Update(repo);
            return appDbContext.SaveChangesAsync();
            
        }
    }
}
