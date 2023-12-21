using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.Service.Dtos.Login;
using OwnShop.Service.JWT.AuthServices;
using System;

namespace OwnShop.WebApi.Controllers.LoginControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly AppDbContext _appDbContext;

       
        public LoginController(IAuthService authService, AppDbContext appDbContext)
        {
            _authService = authService;
            _appDbContext = appDbContext;
        }

        [HttpPost]

        public async ValueTask<IActionResult> Login(LoginDto loginDto)
        {
            var res = await _appDbContext.Customers.FirstOrDefaultAsync(x=>x.PhoneNum == loginDto.PhoneNumber && x.Password == loginDto.Password && x.Role ==loginDto.Role);
            
                string token = _authService.GenerateToken(loginDto);   
            
                return Ok(token);
        }
    }
}
