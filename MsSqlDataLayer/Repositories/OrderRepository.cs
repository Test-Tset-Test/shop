using System.Collections.Generic;
using System.Linq;
using Contracts.Data;
using DataModels;

namespace MsSqlDataLayer.Repositories
{
    public class OrderRepository : MsSqlRepository, IOrderRepository
    {
        public OrderRepository(MsSqlContext context) : base(context) { }
        public List<Order> GetOrders(int idUser)
        {
//             List<Order> data = context.Orders.Where(user => user.UserId == idUser).Select(p => new Order()).ToList();
             return context.Orders.Where(user => user.UserId == idUser).ToList();
        }
    }
}
