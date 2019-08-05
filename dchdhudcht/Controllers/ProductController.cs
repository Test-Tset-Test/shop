using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dchdhudcht.Models;
using Microsoft.AspNetCore.Mvc;

namespace dchdhudcht.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        ApplicationContext db;

        public ProductController(ApplicationContext db)
        {
            this.db = db;
            if (!db.Products.Any())
            {
                db.Products.Add(new Product { Name = "iPhone X", Company = "Apple", Price = 79900 });
                db.Products.Add(new Product { Name = "Galaxy S8", Company = "Samsung", Price = 49900 });
                db.Products.Add(new Product { Name = "Pixel 2", Company = "Google", Price = 52900 });
                db.SaveChanges();
            }
        }
    }
}
