using Contracts.Data;
using DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [Route("api/login")]
    public class LoginController : Controller
    {
        IUserRepository repo;
        public LoginController(IUserRepository repo)
        {
            this.repo = repo;
        }
        [HttpPost]
        public IActionResult LogIn([FromBody]LoginUser data)
        {
            if(!repo.LoginUser(data.Login, data.Password))
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}