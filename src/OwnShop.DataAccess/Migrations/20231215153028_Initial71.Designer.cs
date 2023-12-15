﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OwnShop.DataAccess.Data;

#nullable disable

namespace OwnShop.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231215153028_Initial71")]
    partial class Initial71
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OwnShop.Domain.Entities.Customers.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Products.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CostumerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<long>("ShopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CostumerId");

                    b.HasIndex("ShopId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Sales.Sale", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("ShopId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("SumToltal")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<long>("VendorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShopId");

                    b.HasIndex("VendorId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Shops.Shop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Vendors.Vendor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("ProductSale", b =>
                {
                    b.Property<long>("ProductsId")
                        .HasColumnType("bigint");

                    b.Property<long>("SalesId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductsId", "SalesId");

                    b.HasIndex("SalesId");

                    b.ToTable("ProductSale");
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("OwnShop.Domain.Entities.Customers.Customer", "Customer")
                        .WithMany("Products")
                        .HasForeignKey("CostumerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OwnShop.Domain.Entities.Shops.Shop", "Shop")
                        .WithMany("Products")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Sales.Sale", b =>
                {
                    b.HasOne("OwnShop.Domain.Entities.Customers.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OwnShop.Domain.Entities.Shops.Shop", "Shop")
                        .WithMany("Sales")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OwnShop.Domain.Entities.Vendors.Vendor", "Vendor")
                        .WithMany("Sales")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Shop");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("ProductSale", b =>
                {
                    b.HasOne("OwnShop.Domain.Entities.Products.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OwnShop.Domain.Entities.Sales.Sale", null)
                        .WithMany()
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Customers.Customer", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Shops.Shop", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("OwnShop.Domain.Entities.Vendors.Vendor", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
