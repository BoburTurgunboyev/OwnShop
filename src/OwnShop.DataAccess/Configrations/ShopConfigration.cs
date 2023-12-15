using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OwnShop.Domain.Entities.Sales;
using OwnShop.Domain.Entities.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Configrations
{
    public class ShopConfigration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> entity)
        {
            entity.HasKey(s => s.Id);
            entity.Property(s => s.Name).IsRequired().HasMaxLength(255);
            entity.Property(s => s.Address).IsRequired().HasMaxLength(255);
            entity.Property(s => s.PhoneNum).HasMaxLength(20);

            entity.HasMany(s => s.Products)
                .WithOne(p => p.Shop)
                .HasForeignKey(p => p.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(s => s.Sales)
                .WithOne(s => s.Shop)
                .HasForeignKey(s => s.ShopId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
