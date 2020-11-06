using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        [StringLength (50)]
        public String CategoryId { get; set; }
        [Required]
        [StringLength (100)]
        public String CategoryName { get; set; }
    }
}
