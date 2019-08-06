using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace Shop.Models
{
    //public class ProductContext : ApplicationContext
    //{

    //    public ProductContext(string connectionString) : base(connectionString)
    //    {
    //    }

    //    public List<Product> GetAllProducts()
    //    {
    //        List<Product> list = new List<Product>();

    //        using (MySqlConnection conn = GetConnection())
    //        {
    //            conn.Open();
    //            MySqlCommand cmd = new MySqlCommand("select * from Products where id < 10", conn);

    //            using (var reader = cmd.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    list.Add(new Product()
    //                    {
    //                        Id = Convert.ToInt32(reader["Id"]),
    //                        Name = reader["Name"].ToString(),
    //                        Company = reader["Company"].ToString(),
    //                        Price = Convert.ToInt32(reader["Price"]),
    //                    });
    //                }
    //            }
    //        }
    //        return list;
    //    }

    //}
}
