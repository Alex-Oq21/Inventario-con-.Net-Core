using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public String ProductId { get; set; }
       [Required] 
       [StringLength(100)]
       public String ProductName { get; set; }

       [StringLength(600)]
       public String ProductDescription { get; set; }

        
       public int TotalQuantity { get; set; }

    }
}
