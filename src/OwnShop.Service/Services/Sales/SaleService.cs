using OwnShop.Domain.Entities.Sales;
using OwnShop.Service.Dtos.Sales;
using OwnShop.Service.Interfaces.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Service.Sales
{
    public class SaleService : ISaleService
    {
        public Task<long> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(SaleDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long saleId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Sale>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Sale> GetByIdAsync(long saleId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long saleId, SaleDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
