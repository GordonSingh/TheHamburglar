using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment_one.Models;
using Data;

namespace Assessment_one.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            AdventureContext e = new AdventureContext();
            var allProducts = new Production()
            {
                Products = e.Products
               .Where(p => p.StockNumber > p.SafetyStockNumb)
               .Select(p => new ProductModel
               {
                   ProductId = p.ProductId,
                   Name = p.Name,
                   ProductNumber = p.ProductNumber,
                   Color = p.Color,
                   StandardCost = p.StandardCost,
                   ReorderPoint = p.ReorderPoint,
                   StockNumber = p.StockNumber
               }).ToList()
            };

            return View(allProducts);
        }
           
    }
}
