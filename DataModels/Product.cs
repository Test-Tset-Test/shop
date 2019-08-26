using System.Collections.Generic;

namespace DataModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    // название 
        public int Price { get; set; }  // цена
        public IList<OrderProduct> ProductOrders{ get; set; }
    }
}
