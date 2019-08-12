using DataModels;
using Microsoft.EntityFrameworkCore;

namespace MsSqlDataLayer
{
    public class MsSqlContext : DbContext

    {
        public MsSqlContext(DbContextOptions<MsSqlContext> options)
                  : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
