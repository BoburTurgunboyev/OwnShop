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

        public Task<int> CreateAsync(Product repo)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(long id, Product repo)
        {
            throw new NotImplementedException();
        }
    }
}
