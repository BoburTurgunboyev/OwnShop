using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Configrations;
using OwnShop.Domain.Entities.Customers;
using OwnShop.Domain.Entities.Products;
using OwnShop.Domain.Entities.Sales;
using OwnShop.Domain.Entities.Shops;
using OwnShop.Domain.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
   

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfigration());
            modelBuilder.ApplyConfiguration(new ProductConfigration());
            modelBuilder.ApplyConfiguration(new SaleConfigration());
            modelBuilder.ApplyConfiguration(new ShopConfigration());
            modelBuilder.ApplyConfiguration(new  VendorConfigration());
        }

    }
}
