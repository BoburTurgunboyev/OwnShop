using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Exceptions.Sales
{
    public class SaleNotFound:NotFoundException
    {
        public SaleNotFound() 
        {
            Massage = "Sale not found";
        }
    }
}
