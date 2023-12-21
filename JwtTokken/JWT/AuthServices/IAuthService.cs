using OwnShop.Service.Dtos.Login;

namespace OwnShop.Service.JWT.AuthServices
{
    public interface IAuthService
    {
        public string GenerateToken(LoginDto loginDto);

    }
}
