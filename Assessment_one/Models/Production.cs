using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Entities;

namespace Assessment_one.Models
{
    public class Production :ProductModel
    {
        public List<ProductModel> Products { get; set; }
        public List<ProductDescriptionModel> ProductDescriptions { get; set; }
    }
}