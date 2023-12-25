using OwnShop.DataAccess.Interfaces.Sales;
using OwnShop.Domain.Entities.Sales;
using OwnShop.Domain.Exceptions.Sales;
using OwnShop.Domain.Exceptions.Vendors;
using OwnShop.Service.Dtos.Sales;
using OwnShop.Service.Dtos.Vendors;
using OwnShop.Service.Interfaces.Sales;
 
namespace OwnShop.Service.Service.Sales
{
    public class SaleService : ISaleService
    {
        private ISaleRepository _saleRepository;

        public SaleService(ISaleRepository saleRepository)
        {
            this._saleRepository = saleRepository;

        }

        public async Task<long> CountAsync()
        {
            return await _saleRepository.CountAsync();
           
        }

        public async  Task<bool> CreateAsync(SaleDto dto)
        {
            Sale sale = new Sale()
            {
                SumToltal = dto.SumToltal,
                CustomerId = dto.CustomerId,
                ProductId = dto.ProductId,
                ShopId = dto.ShopId,
                VendorId = dto.VendorId,
            };

           int result = await _saleRepository.CreateAsync(sale);
           return result > 0;
        }

        public async Task<bool> DeleteAsync(long saleId)
        {
            var result = _saleRepository.GetByIdAsync(saleId);
            if (result == null) throw new SaleNotFound();

            return  await _saleRepository.DeleteAsync(saleId);
        }

        public Task<IList<Sale>> GetAllAsync()
        {
           return _saleRepository.GetAllAsync();    
        }

        public Task<Sale> GetByIdAsync(long saleId)
        {
            var result = _saleRepository.GetByIdAsync(saleId);
            if (result == null) throw new SaleNotFound();
            else return result;

        }

        public async Task<bool> UpdateAsync(long saleId, SaleDto dto)
        {
            var result = await _saleRepository.GetByIdAsync(saleId);
            if (result == null) throw new SaleNotFound();

            result.SumToltal = dto.SumToltal;
            int sale = await _saleRepository.UpdateAsync(saleId, result);
            return sale > 0;
        }
    }
}

