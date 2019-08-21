using System.Collections.Generic;
using Contracts.Data;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Shop.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        IProductRepository repo;
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }


        [System.Web.Mvc.HttpGet]/*("[action]")]*/
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
