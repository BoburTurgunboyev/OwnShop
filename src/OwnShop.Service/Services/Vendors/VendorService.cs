using OwnShop.Domain.Entities.Vendors;
using OwnShop.Service.Dtos.Vendors;
using OwnShop.Service.Interfaces.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Service.Vendors
{
    public class VendorService : IVendorService
    {
        public Task<long> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(VendorDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long vendorId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Vendor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> GetByIdAsync(long vendorId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long vendorId, VendorDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
