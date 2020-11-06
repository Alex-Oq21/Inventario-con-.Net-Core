using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WherehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WhereHouseId { get; set; }

        [StringLength(100)]
        [Required]
        public string WherehouseName { get; set; }

        [StringLength(100)]
        [Required]
        public string WherehouseAddress { get; set; }

        //Relación con Almacenamiento o Storage
        public ICollection<StorageEntity> Storages {get; set;}
    }
}
