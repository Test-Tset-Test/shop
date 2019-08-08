using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts.Data;
using DataModels;

namespace MsSqlDataLayer.Repositories
{
    public class OrdersRepository : MsSqlRepository, IOrderRepository
    {
        public OrdersRepository(MsSqlContext context) : base(context) { }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    ProductId = 1
                }
            );
            modelBuilder.Entity<Order>().HasData(
                new Order { ProductId = 3 },
                new Order { ProductId = 2 },
                new Order { ProductId = 1 }
            );
        }*/
        public List<Order> GetOrders()
        {
            return this.context.Orders.ToList();
        }
    }
}
