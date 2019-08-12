using Contracts.Data;
using DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [Route("api/registration")]
    public class RegistrationController : Controller
    {
        IUserRepository repo;
        public RegistrationController(IUserRepository repo)
        {
            this.repo = repo;
        }
        [HttpPost]
        public IActionResult Register([FromBody]User userDto)
        {
            if(!repo.CreateUser(userDto))
            {
                return BadRequest();
            }
            // map dto to entity
            
            return Ok();
        }
    }
}