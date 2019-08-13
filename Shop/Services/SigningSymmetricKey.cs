using System.Text;
using Contracts.Data;
using Microsoft.IdentityModel.Tokens;

namespace Shop.Services
{
    public class SigningSymmetricKey : IJwtSigningEncodingKey, IJwtSigningDecodingKey
    {
        private readonly SymmetricSecurityKey _secretKey;
 
        public string SigningAlgorithm { get; } = SecurityAlgorithms.HmacSha256;
 
        public SigningSymmetricKey(string key)
        {
            _secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        }
 
        public SecurityKey GetKey() => _secretKey;
    }
}