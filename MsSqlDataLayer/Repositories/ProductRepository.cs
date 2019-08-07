using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModels;
using MySqlDataLayer.Repositories;

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
