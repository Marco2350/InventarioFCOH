using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Factura
    {
        public int FacturaId { get; set; }
        public int? ClienteId { get; set; }
        public string? Estado { get; set; }
        public string? Tipo { get; set; }
        public DateTime? Fecha { get; set; }
        public int? AreaId { get; set; }
    }
}
