using System.Collections.Generic;
using System.Linq;
using Contracts.Data;
using DataModels;

namespace MsSqlDataLayer.Repositories
{
    public class OrderProductRepository : MsSqlRepository, IOrderProductRepository
    {
        public OrderProductRepository(MsSqlContext context) : base(context)
        {
        }

        public List<OrderProduct> GetOrderProduct(int idOrderGroup)
        {
//             List<Order> data = context.Orders.Where(user => user.UserId == idUser).Select(p => new Order()).ToList();
            return context.ProductOrders.Where(order => order.OrderId == idOrderGroup).ToList();
        }
    }
}