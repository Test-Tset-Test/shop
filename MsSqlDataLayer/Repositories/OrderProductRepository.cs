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

        public List<OrderProductView> GetOrderProduct(int idOrderGroup)
        {
            List<OrderProductView> data = (from pd in context.ProductOrders
                    join od in context.Products on pd.ProductId equals od.Id
                    select new
                    {
                        pd.OrderId,
                        pd.Count,
                        od.Name,
                        od.Price
                    }
                ).Where(order => order.OrderId == idOrderGroup).Select(x => new OrderProductView()
                {
                    Name = x.Name,
                    Price = x.Price,
                    Count = x.Count,
                    OrderId = x.OrderId
                }).ToList();
            return data;
        }
    }
}