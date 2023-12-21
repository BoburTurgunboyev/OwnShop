using OwnShop.Domain.Entities.Customers;
using OwnShop.Domain.Entities.Products;
using OwnShop.Domain.Entities.Shops;
using OwnShop.Domain.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Entities.Sales
{
    public class Sale
    {
        public long Id { get; set; }

        public decimal SumToltal { get; set; }

        public long CustomerId {  get; set; }   
        public Customer Customer { get; set; }


        public long VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public long ShopId { get; set; }
        public Shop Shop { get; set; }

        public long ProductId {  get; set; }
        public Product Product { get; set; }    


    }
}
