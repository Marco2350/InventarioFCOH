using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class VwHistoricalReport
    {
        public string NombreUsuario { get; set; } = null!;
        public string? CodigoEquipo { get; set; }
        public string? NombreEquipo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
    }
}
