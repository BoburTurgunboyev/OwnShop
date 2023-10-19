using OwnShop.Domain.Entities.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Interfaces.Shops
{
    public interface IShopRepository:IRepository<Shop,Shop>
    {
    }
}
