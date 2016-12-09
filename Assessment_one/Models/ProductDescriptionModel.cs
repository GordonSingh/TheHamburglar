using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;
namespace Assessment_one.Models
{
    public class ProductDescriptionModel
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDateTime { get; set; }
    }
}