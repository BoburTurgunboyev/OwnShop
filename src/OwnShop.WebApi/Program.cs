using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Customers;
using OwnShop.DataAccess.Interfaces.Products;
using OwnShop.DataAccess.Interfaces.Sales;
using OwnShop.DataAccess.Interfaces.Shops;
using OwnShop.DataAccess.Interfaces.Vendors;
using OwnShop.DataAccess.Repositories.Cotegories;
using OwnShop.Service.Interfaces.Customers;
using OwnShop.Service.Interfaces.Products;
using OwnShop.Service.Interfaces.Sales;
using OwnShop.Service.Interfaces.Shops;
using OwnShop.Service.Interfaces.Vendors;
using OwnShop.Service.Service.Customers;
using OwnShop.Service.Service.Products;
using OwnShop.Service.Service.Sales;
using OwnShop.Service.Service.Shops;
using OwnShop.Service.Service.Vendors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Repositories
builder.Services.AddScoped<ICustomerRepository, CostumerRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ISaleRepository, SaleRepository>();
builder.Services.AddScoped<IShopRepository, ShopRepository>();
builder.Services.AddScoped<IVendorRepository, VendorRepository>();

// Services

builder.Services.AddScoped<ICustomersService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISaleService,SaleService>();
builder.Services.AddScoped<IShopService,ShopService>();
builder.Services.AddScoped<IVendorService,VendorService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options
    => options.UseSqlServer(builder.Configuration.GetConnectionString("Connected")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
