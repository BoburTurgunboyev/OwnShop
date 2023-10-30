using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Exceptions.Vendors
{
    public class VendorNotFound:NotFoundException
    {
        public VendorNotFound()
        {
            Massage = "Vendor not found";
        }
    }
}
