using OwnShop.Domain.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Interfaces.Sales
{
    public interface ISaleRepository:IRepository<Sale,Sale>
    {
    }
}
