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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        //public ActionResult Search()
        //{
        //    ViewBag.Message = "Your contact page.";

        //   return View();
        //}
    }
}