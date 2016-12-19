using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("ProductDescription")]
    public class ProductDescription
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public virtual ICollection<ProductDescription> ProductDescriptions { get; set; }
    }
}
