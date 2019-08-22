using System.Collections.Generic;
using System.Security.Claims;
using Contracts.Data;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Shop.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        IOrderRepository repo;
        public OrdersController(IOrderRepository repo)
        {
            this.repo = repo;
        }


        [System.Web.Mvc.HttpGet]/*("[action]")]*/
        public IEnumerable<Order> Get()
        {
            var idUser  = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return repo.GetOrders(System.Int32.Parse(idUser));
        }
    }
}