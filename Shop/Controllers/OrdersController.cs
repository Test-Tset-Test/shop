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
        IOrderRepository orderDb;
        IOrderProductRepository orderProductDb;
        public OrdersController(IOrderRepository orderDb, IOrderProductRepository orderProductDb)
        {
            this.orderDb = orderDb;
            this.orderProductDb = orderProductDb;
        }
    
        [HttpGet("list")]
        public IEnumerable<Order> List()
        {
            var idUser  = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return orderDb.GetOrders(System.Int32.Parse(idUser));
        }
        [HttpGet("order")]
        public IEnumerable<OrderProduct> Order(int id)
        {
            return orderProductDb.GetOrderProduct(id);
        }
    }
}