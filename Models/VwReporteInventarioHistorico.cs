using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class VwReporteInventarioHistorico
    {
        public string IdEquipo { get; set; }
        public string? Descripción { get; set; }
        public string Categoría { get; set; } = null!;
        public string PrecioDeCompra { get; set; } = null!;
        public DateTime Adquisición { get; set; }
        public DateTime? Baja { get; set; }
    }
}
