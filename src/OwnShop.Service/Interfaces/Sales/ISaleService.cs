using OwnShop.Domain.Entities.Sales;
using OwnShop.Service.Dtos.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Interfaces.Sales
{
    public interface ISaleService
    {
        public Task<bool> CreateAsync(SaleDto dto);

        public Task<bool> UpdateAsync(long saleId, SaleDto dto);

        public Task<bool> DeleteAsync(long saleId);

        public Task<long> CountAsync();

        public Task<IList<Sale>> GetAllAsync();
        
        public Task<Sale> GetByIdAsync(long saleId);
    }
}
