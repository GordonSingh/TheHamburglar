using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Assessment_one.Models;
using Data;
using Data.Entities;
using PagedList;

namespace Assessment_one.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ActionResult Index(int page=1 ,int pageSize=10)
        {
            AdventureContext e = new AdventureContext();
            var prod=new ProductModel().productsM;
            prod = e.Products.ToList();

            return View(prod.ToPagedList(page,pageSize));
        }

    }
}
