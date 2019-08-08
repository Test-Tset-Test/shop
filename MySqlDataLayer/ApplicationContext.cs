using DataModels;
using Microsoft.EntityFrameworkCore;

namespace MySqlDataLayer
{
    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MySqlContext: DbContext

    {

        public MySqlContext(DbContextOptions<MySqlContext> options)
                  : base(options)
        { }




        //protected MySqlConnection GetConnection()
        //{
        //    return new MySqlConnection(this.);
        //}


        public DbSet<Product> Products { get; set; }
    }
}
