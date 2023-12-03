using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class VwReporteInventarioHistorico
    {
        public int EquipoId { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime FechaAsignacion { get; set; }
        public string? FechaDesasignacionFormateada { get; set; }
    }
}
