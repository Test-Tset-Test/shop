using DataModels;
using Microsoft.EntityFrameworkCore;

namespace MsSqlDataLayer
{
    public class MsSqlContext : DbContext

    {
        public MsSqlContext(DbContextOptions<MsSqlContext> options)
                  : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasKey(sc => new { sc.ProductId, sc.OrderId });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> ProductOrders { get; set; }
    }
}
