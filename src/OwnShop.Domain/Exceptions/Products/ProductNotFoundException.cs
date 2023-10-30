using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Exceptions.Products
{
    public class ProductNotFoundException:NotFoundException
    {
        public ProductNotFoundException()
        {
            Massage = "Product not found";
        }
    }
}
