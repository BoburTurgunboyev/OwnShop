
using OwnShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.Service.Dtos.Login
{
    public class LoginDto
    {
       

        public string PhoneNumber { get; set; }   
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
