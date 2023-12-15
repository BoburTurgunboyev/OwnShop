using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OwnShop.Domain.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Configrations
{
    public class SaleConfigration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> entity)
        {

            entity.HasKey(s => s.Id);
            entity.Property(s => s.SumToltal).HasColumnType("decimal(18, 2)");

            entity.HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.Vendor)
                .WithMany(v => v.Sales)
                .HasForeignKey(s => s.VendorId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.Shop)
                .WithMany(sh => sh.Sales)
                .HasForeignKey(s => s.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
