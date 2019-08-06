using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace dchdhudcht.Models
{
    /*
        Add-Migration Initial
        Update-Database
    */

    public class ApplicationContext
    {
        public string ConnectionString { get; set; }

        public ApplicationContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public DbSet<Product> Products { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Products where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Company = reader["Company"].ToString(),
                            Price = Convert.ToInt32(reader["Price"]),
                        });
                    }
                }
            }
            return list;
        }
    }
}
