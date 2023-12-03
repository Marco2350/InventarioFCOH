using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Asignacione
    {
        public int AsignacionId { get; set; }
        public int EquipoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAsignacion { get; set; }

        public virtual Equipo Equipo { get; set; } = null!;
        public virtual Usuario Usuario { get; set; } = null!;
    }
}
