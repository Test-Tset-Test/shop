using System.Collections.Generic;
using System.Linq;
using Contracts.Data;
using DataModels;

namespace MsSqlDataLayer.Repositories
{
    public class OrdersRepository : MsSqlRepository, IOrderRepository
    {
        public OrdersRepository(MsSqlContext context) : base(context) { }

        public List<Order> GetOrders()
        {
            return this.context.Orders.ToList();
        }
    }
}
