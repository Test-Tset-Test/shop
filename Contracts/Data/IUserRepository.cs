using DataModels;
using Microsoft.IdentityModel.Tokens;

namespace Contracts.Data
{
    public interface IUserRepository
    {
        bool CreateUser(User data);
        bool LoginUser(string login, string password);
    }
    // Ключ для создания подписи (приватный)
    public interface IJwtSigningEncodingKey
    {
        string SigningAlgorithm { get; }
 
        SecurityKey GetKey();
    }
    
    // Ключ для проверки подписи (публичный)
    public interface IJwtSigningDecodingKey
    {
        SecurityKey GetKey();
    }
}