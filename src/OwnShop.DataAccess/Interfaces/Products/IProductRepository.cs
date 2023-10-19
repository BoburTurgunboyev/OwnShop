using OwnShop.Domain.Entities.Customers;
using OwnShop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Interfaces.Products
{
    public interface IProductRepository: IRepository<Product, Product>
    {
    }
}
