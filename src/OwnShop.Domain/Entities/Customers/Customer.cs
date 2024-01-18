using OwnShop.Domain.Entities.Products;
using OwnShop.Domain.Entities.Sales;
using OwnShop.Domain.Enums;


namespace OwnShop.Domain.Entities.Customers
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNum { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Password { get; set; }
        public Role Role { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
