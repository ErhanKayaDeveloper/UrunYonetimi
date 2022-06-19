using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UrunYonetimi.Models;
namespace UrunYonetimi.Controllers
{
    public class UrunYonetimiController : ApiController
    {
        DataContext db = new DataContext();
        // GET: api/UrunYonetimi
        public IEnumerable<Product> Get()
        {
            var product = db.Product.ToList();
            return product;
        }

        // GET: api/UrunYonetimi/5
        public IHttpActionResult Get(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                return Ok(product);//200
            }
            else
            {
                return NotFound();//404
            }
        }
        public string Delete(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                db.Product.Remove(product);
                db.SaveChanges();
                return product.Name+" Adlı Ürün Silindi";//200
            }
            else
            {
                return "Aradığınız Ürün Bulunamadı";//404
            }
        }
        // POST: api/UrunYonetimi
        [HttpPost]
        public IHttpActionResult Post([FromBody]Product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
            return Ok();//200
        }

        // PUT: api/UrunYonetimi/5
        public string Put(int id, [FromBody]Product product)
        {
            var editproduct = db.Product.Find(id);

            editproduct.Name = product.Name;
            editproduct.Description = product.Description;
            editproduct.Price = product.Price;
            editproduct.Stock = product.Stock;
            editproduct.Status = product.Status;

            db.SaveChanges();

            return editproduct.Name + " Adlı Ürün Düzenlendi";
        }

       
    }
}
