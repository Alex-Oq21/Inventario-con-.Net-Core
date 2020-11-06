using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    class WherehouseEntity
    {
        [Key]
        [StringLength(50)]
        public String WhereHouseId { get; set; }

        [StringLength(100)]
        [Required]
        public String WherehouseName { get; set; }

        [StringLength(50)]
        [Required]
        public String WherehouseAddress { get; set; }
    }
}
