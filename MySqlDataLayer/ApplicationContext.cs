using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

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
