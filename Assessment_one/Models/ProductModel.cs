using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;
using Data.Entities;

namespace Assessment_one.Models
{
    public class ProductModel:Product
    {
        public List<Product> productsM = new List<Product>();    
    }
}