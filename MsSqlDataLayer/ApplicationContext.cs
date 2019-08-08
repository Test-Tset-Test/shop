using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using Microsoft.EntityFrameworkCore;

namespace MySqlDataLayer
{
    public class MsSqlContext : DbContext

    {
        public MsSqlContext(DbContextOptions<MsSqlContext> options)
                  : base(options)
        { }
        public DbSet<Product> Products { get; set; }
    }
}
