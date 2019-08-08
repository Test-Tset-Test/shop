using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModels;

namespace Contracts.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
