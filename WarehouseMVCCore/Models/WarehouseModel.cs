using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseMVCCore.Models
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Max 50 znaków")]
        public string Name { get; set; }
        public int Quantity { get; set; }

    }
}
