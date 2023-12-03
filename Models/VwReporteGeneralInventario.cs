using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class VwReporteGeneralInventario
    {
        public string EquipoId { get; set; }
        public string? DescripcionGeneral { get; set; }
        public string PrecioDeCompra { get; set; } = null!;
        public string? FechaDeCompra { get; set; }
    }
}
