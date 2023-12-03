using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class VwHistoricalReport
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public int EquipoId { get; set; }
        public string? NombreEquipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
    }
}
