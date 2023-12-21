using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OwnShop.Service.Dtos.Login;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OwnShop.Service.JWT.AuthServices
{
    public class AuthService : IAuthService
    {

        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(LoginDto loginDto)
        {
            var claims = new Claim[]
          {
                // name 
                new Claim("PhoneNumber", loginDto.PhoneNumber),
                // identificatori
                new Claim("Password",loginDto.Password),
                new Claim(ClaimTypes.Role,loginDto.Role.ToString()),
                // vaqti
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString()),

          };

            // qandedur algoritm boyicha shifrlanadi
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"])),
                SecurityAlgorithms.HmacSha256
                );

            var token = new JwtSecurityToken(
                _configuration["JWT:ValidIssuer"],
                _configuration["JWT:ValidAudience"],
                claims,
                expires: DateTime.Now.AddSeconds(60),
                signingCredentials: credentials
                );

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);


        }
    }
}
