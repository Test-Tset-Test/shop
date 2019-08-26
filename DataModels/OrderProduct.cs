namespace DataModels
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Count { get; set; }
    }
    public class OrderProductView
    {
        public int OrderId { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}