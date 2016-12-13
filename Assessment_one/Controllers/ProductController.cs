using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment_one.Models;
using Data;
using Data.Entities;

namespace Assessment_one.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            AdventureContext e = new AdventureContext();
            var allProducts = new Production
            {
                Products = e.Products
                    .Where(p => p.StockNumber > p.SafetyStockNumb)
                    .Select(p => new ProductModel
                    {
                        Name = p.Name,
                        ProductNumber = p.ProductNumber,
                        Color = p.Color,
                        StockNumber = p.StockNumber,
                        StandardCost = p.StandardCost,
                        ProductId = p.ProductId
                    })
                    .ToList()
            };


            //var product = new Production
            //{
            //  Name = "Lead Pipe",
            //  Color = "Black",
            //  ProductNumber = 12,
            //  ReorderPoint = false,
            //  StockNumber = 14,
            //  StandardCost = 12.40
            //};

            return View(allProducts);
        }
           
    }
}
