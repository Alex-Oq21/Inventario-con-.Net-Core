using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WareHouseId { get; set; }

        [StringLength(100)]
        [Required]
        public string WarehouseName { get; set; }

        [StringLength(100)]
        [Required]
        public string WarehouseAddress { get; set; }

        //Relación con Almacenamiento o Storage
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
