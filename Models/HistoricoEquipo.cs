using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class HistoricoEquipo
    {
        public int HistoricoId { get; set; }
        public int EquipoId { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Motivo { get; set; } = null!;

        public virtual Equipo Equipo { get; set; } = null!;
    }
}
