using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Data.Entities
{
    public class Product
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ProductNumber { get; set; }

        public string Color { get; set; }

        [Required]
        public int SafetyStockNumb { get; set; }

        [Required]
        public int StockNumber { get; set; }

        [Required]
        public bool ReorderPoint { get; set; }

        [Required]
        public double StandardCost { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}