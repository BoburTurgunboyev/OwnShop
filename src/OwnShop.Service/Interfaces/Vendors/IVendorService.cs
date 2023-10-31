using OwnShop.Domain.Entities.Vendors;
using OwnShop.Service.Dtos.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Interfaces.Vendors
{
    public interface IVendorService
    {
        public Task<bool> CreateAsync(VendorDto dto);

        public Task<bool> UpdateAsync(long vendorId, VendorDto dto);

        public Task<bool> DeleteAsync(long vendorId);

        public Task<long> CountAsync();

        public Task<Vendor> GetByIdAsync(long vendorId);
        public Task<IList<Vendor>> GetAllAsync();

    }
}
