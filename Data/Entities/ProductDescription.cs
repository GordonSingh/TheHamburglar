using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProductDescription
    {
        public int ProductId { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
