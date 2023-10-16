using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Entities.Vendors
{
    public class Vendor
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
