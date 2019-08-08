using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Data;
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
        public IEnumerable<DataModels.Order> Get()
        {
            return repo.GetOrders();
        }
    }
}