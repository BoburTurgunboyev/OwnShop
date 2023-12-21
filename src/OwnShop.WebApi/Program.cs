using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
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
using OwnShop.Service.JWT.AuthServices;
using OwnShop.Service.Service.Customers;
using OwnShop.Service.Service.Products;
using OwnShop.Service.Service.Sales;
using OwnShop.Service.Service.Shops;
using OwnShop.Service.Service.Vendors;
using System.Text;

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

builder.Services.AddScoped<IAuthService,  AuthService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options
    => options.UseSqlServer(builder.Configuration.GetConnectionString("Connected")));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opttins =>
                {
                    opttins.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        // kimga chiqarilgan
                        ValidateIssuer = true,
                        // kim tomonidan berilgan
                        ValidateAudience = true,
                        // vaqti
                        ValidateLifetime = true,
                        // secret keyi
                        ValidateIssuerSigningKey = true,
                        ValidAudience = builder.Configuration["JWT:ValidAudience"],
                        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
                    };
                });

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("V1", new OpenApiInfo
    {
        Version = "v1",
        Title = "AuthDemo",
        Description = "Auth Demo Description"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        Description = "Bearer Authentication",
        Type = SecuritySchemeType.Http
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new List<string> ()
                    }

                });
});



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/V1/swagger.json", "Auth Demo API");
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
