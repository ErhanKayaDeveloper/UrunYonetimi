using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrunYonetimi.Models;
namespace UrunYonetimi.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            var product = db.Product.ToList();

            return View(product);
        }
        public ActionResult Add(){

            return View();

        } 
        [HttpPost]
        public ActionResult Add(Product product){

            db.Product.Add(product);
            db.SaveChanges();
            return View();

        }
        public ActionResult Delete(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                db.Product.Remove(product);
                db.SaveChanges();
            }
            return Redirect(Request.UrlReferrer.ToString());

        }
    }
}