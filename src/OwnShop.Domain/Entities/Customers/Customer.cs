using OwnShop.Domain.Entities.Products;
using OwnShop.Domain.Entities.Sales;


namespace OwnShop.Domain.Entities.Customers
{
    public class Customer
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string PhoneNum { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
