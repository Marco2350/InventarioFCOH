using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class FacturaDetalle
    {
        public int? FacturaId { get; set; }
        public int? ArticuloId { get; set; }
        public double? Cantidad { get; set; }
        public double? Precio { get; set; }
        public double? Isv { get; set; }
    }
}
