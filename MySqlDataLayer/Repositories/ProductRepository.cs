using System.Collections.Generic;
using System.Linq;
using Contracts.Data;
using DataModels;

namespace MySqlDataLayer.Repositories
{
    public class ProductRepository : MySqlRepository, IProductRepository
    {
        public ProductRepository(MySqlContext context):base(context) { }
        public List<Product> GetProducts() {
            return this.context.Products.ToList();
        }
    }
}
