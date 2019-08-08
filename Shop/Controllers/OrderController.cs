using System.Collections.Generic;
using Contracts.Data;
using Microsoft.AspNetCore.Mvc;
using DataModels;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        IOrderRepository repo;
        public OrderController(IOrderRepository repo)
        {
            this.repo = repo;
        }


        [HttpGet]
        public IEnumerable<Order> Get()
        {
            var test = "K_C";
            return repo.GetOrders();
        }
    }
}