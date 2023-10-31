using OwnShop.DataAccess.Interfaces.Vendors;
using OwnShop.Domain.Entities.Vendors;
using OwnShop.Domain.Exceptions;
using OwnShop.Domain.Exceptions.Vendors;
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
        private IVendorRepository _vendorRepository;

        public VendorService(IVendorRepository vendorRepository) 
        {
            this._vendorRepository = vendorRepository;
            
        }

        public async Task<long> CountAsync()
        {
           return await _vendorRepository.CountAsync();
           
        }

        public async Task<bool> CreateAsync(VendorDto dto)
        {
            Vendor vendor = new Vendor()
            {
                Name = dto.Name
            };
            int result = await _vendorRepository.CreateAsync(vendor);
            return result > 0;
        }

        public async Task<bool> DeleteAsync(long vendorId)
        {
            var vendor = _vendorRepository.GetByIdAsync(vendorId);
            if (vendor == null) throw new VendorNotFound();

            return await _vendorRepository.DeleteAsync(vendorId);
            
        }

        public Task<IList<Vendor>> GetAllAsync()
        {
            var result = _vendorRepository.GetAllAsync();
            return result;
        }

        public Task<Vendor> GetByIdAsync(long vendorId)
        {
            var vendor = _vendorRepository.GetByIdAsync(vendorId);
            if(vendor == null) throw new VendorNotFound();
            else return vendor;
        }

        public async Task<bool> UpdateAsync(long vendorId, VendorDto dto)
        {
            var result = await _vendorRepository.GetByIdAsync(vendorId);
            if (result == null) throw new VendorNotFound();
           
             result.Name = dto.Name;
            int vendor = await _vendorRepository.UpdateAsync(vendorId, result);
            return vendor > 0;
            
            
        }
    }
}
