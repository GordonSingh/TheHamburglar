using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;
using Data.Entities;

namespace Assessment_one.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        
        public string Name { get; set; }
        public int ProductNumber { get; set; }
        public string Color { get; set; }
        public int SafetyStockNumb { get; set; }
        public int StockNumber { get; set; }
        public bool ReorderPoint { get; set; }

        [DataType(DataType.Currency)]
        public double StandardCost { get; set; }
    }
}