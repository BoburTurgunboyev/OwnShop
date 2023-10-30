using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Domain.Exceptions
{
    public class NotFoundException : Exception
    {

        public string Massage {  get; set; }
    }
}

