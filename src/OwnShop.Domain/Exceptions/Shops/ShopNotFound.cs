using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Exceptions.Shops
{
    public class ShopNotFound: NotFoundException
    {
        public ShopNotFound() 
        {
            Massage = "Shop not found";
        }
    }
}
