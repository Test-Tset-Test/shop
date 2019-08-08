using System.Collections.Generic;
using Contracts.Data;
using DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [Route("api/orders")]
    public class OrderController : Controller
    {
        IOrderRepository repo;
        public OrderController(IOrderRepository repo)
        {
            this.repo = repo;
        }


        [HttpGet]/*("[action]")]*/
        public IEnumerable<Order> Get()
        {
            return repo.GetOrders();
        }
    }
}