using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        public String CategoryId { get; set; }
        public String CategoryName { get; set; }
    }
}
