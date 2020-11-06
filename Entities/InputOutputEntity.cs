using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    class InputOutputEntity
    {
        [Key]
        [StringLength(50)]
        public String InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int IsInput { get; set; }
    }
}
