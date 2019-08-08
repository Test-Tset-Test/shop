using System;
using System.Collections.Generic;
using System.Text;
using DataModels;

namespace Contracts.Data
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
    }
}
