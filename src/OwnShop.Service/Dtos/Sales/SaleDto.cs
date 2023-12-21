using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Dtos.Sales
{
    public class SaleDto
    {
        public decimal SumToltal { get; set;}
        public long ProductId { get; set; }
        public long ShopId { get; set; }
        public long VendorId { get; set; }
        public long CustomerId { get; set; }
    }
}
