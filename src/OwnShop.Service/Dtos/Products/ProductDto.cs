using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Dtos.Products
{
    public class ProductDto
    {
          public string Name { get; set; } = string.Empty;    
          public int Price { get; set; }
          public long CostumerId { get; set; }
          public long ShopId { get; set; }
    }
}
