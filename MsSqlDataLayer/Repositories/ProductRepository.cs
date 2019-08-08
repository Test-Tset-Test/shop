using System.Collections.Generic;
using System.Linq;
using Contracts.Data;
using DataModels;

namespace MsSqlDataLayer.Repositories
{
    public class ProductRepository : MsSqlRepository, IProductRepository
    {
        public ProductRepository(MsSqlContext context) : base(context) { }
        public List<Product> GetProducts()
        {
            return this.context.Products.ToList();
        }
    }
}
