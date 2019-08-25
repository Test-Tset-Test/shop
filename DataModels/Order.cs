using System.Collections.Generic;

namespace DataModels
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IList<OrderProduct> ProductOrders{ get; set; }
    }
}
