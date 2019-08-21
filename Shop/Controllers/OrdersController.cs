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
            var tast  = User.FindFirstValue(ClaimTypes.NameIdentifier);
             var tes = User.Identity.ToString();
            return repo.GetOrders();
        }
    }
}