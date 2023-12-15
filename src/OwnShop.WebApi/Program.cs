using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Customers;
using OwnShop.DataAccess.Interfaces.Products;
using OwnShop.DataAccess.Repositories.Cotegories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICustomerRepository, CostumerRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

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
