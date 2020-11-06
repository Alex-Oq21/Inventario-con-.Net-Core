﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        //Relación con productos
       public string ProductId { get; set; }
       public ProductEntity Product { get; set; }

        //Relación con Bodega o Wherehouse
        public string WhereHouseId { get; set; }
        public WherehouseEntity wherehouse { get; set; } 

        //Relación con movimientos o InputOutPut
        public ICollection<InputOutputEntity> inputOutputs { get; set; }

    }
}
