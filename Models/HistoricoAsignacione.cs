using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class HistoricoAsignacione
    {
        public int HistoricoId { get; set; }
        public int EquipoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime? FechaDesasignacion { get; set; }

        public virtual Equipo Equipo { get; set; } = null!;
        public virtual Usuario Usuario { get; set; } = null!;
    }
}
