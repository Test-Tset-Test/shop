using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Web.Mvc;
using Contracts.Data;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Shop.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/login")]
    public class LoginController : Controller
    {
        IUserRepository repo;
        public LoginController(IUserRepository repo)
        {
            this.repo = repo;
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public string LogIn([FromBody]LoginUser data, [FromServices] IJwtSigningEncodingKey signingEncodingKey)
        {
            if(repo.LoginUser(data.Login, data.Password))
            {
                ActionResult<string> tokenSecure = CreateToken(data, signingEncodingKey);
                return JsonConvert.SerializeObject(tokenSecure);
                ;
            }
            return "false";
        }
        
        [AllowAnonymous]
        private ActionResult<string> CreateToken(
            LoginUser authRequest,
            [FromServices] IJwtSigningEncodingKey signingEncodingKey)
        {
            // 1. Проверяем данные пользователя из запроса.
            // ...
 
            // 2. Создаем утверждения для токена.
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, authRequest.Login)
            };
 
            // 3. Генерируем JWT.
            var token = new JwtSecurityToken(
                issuer: "Shop",
                audience: "Shop",
                claims: claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: new SigningCredentials(
                    signingEncodingKey.GetKey(),
                    signingEncodingKey.SigningAlgorithm)
            );
 
            string jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}