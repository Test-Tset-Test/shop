using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Contracts.Repositories;
using DataModels;

namespace Shop.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        IProductRepository repo;
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
            //this.db = db;
            /* if (!db.Products.Any())
             {
                 db.Products.Add(new Product { Name = "iPhone X", Company = "Apple", Price = 79900 });
                 db.Products.Add(new Product { Name = "Galaxy S8", Company = "Samsung", Price = 49900 });
                 db.Products.Add(new Product { Name = "Pixel 2", Company = "Google", Price = 52900 });
                 db.SaveChanges();
             }*/
        }


        [HttpGet]/*("[action]")]*/
        public IEnumerable<Product> Get()
        {
            return repo.GetProducts();
        }

        //[HttpGet("{id}")]
        //public Product Get(int id)
        //{
        //    Product product = db.Products.FirstOrDefault(x => x.Id == id);
        //    return product;
        //}

        //[HttpPost]
        //public IActionResult Post([FromBody]Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Products.Add(product);
        //        db.SaveChanges();
        //        return Ok(product);
        //    }
        //    return BadRequest(ModelState);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody]Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Update(product);
        //        db.SaveChanges();
        //        return Ok(product);
        //    }
        //    return BadRequest(ModelState);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    Product product = db.Products.FirstOrDefault(x => x.Id == id);
        //    if (product != null)
        //    {
        //        db.Products.Remove(product);
        //        db.SaveChanges();
        //    }
        //    return Ok(product);
        //}
    }
}
