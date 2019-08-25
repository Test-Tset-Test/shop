using System.Collections.Generic;
using DataModels;

namespace Contracts.Data
{
    
    public interface IOrderProductRepository
    {
        List<OrderProduct> GetOrderProduct(int idOrderGroup);
    }
}