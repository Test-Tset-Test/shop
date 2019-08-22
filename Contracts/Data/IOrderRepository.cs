using System.Collections.Generic;
using DataModels;

namespace Contracts.Data
{
    public interface IOrderRepository
    {
        List<Order> GetOrders(int idUser);
    }
}
