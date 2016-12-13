using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Entities;

namespace Assessment_one.Models
{
    public class Production 
    {
        public List<ProductModel> Products =new List<ProductModel>();
        public List<ProductDescriptionModel> ProductDescriptions =new List<ProductDescriptionModel>();
    }
}