using System.Collections.Generic;
using DataModels;

namespace Contracts.Data
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
