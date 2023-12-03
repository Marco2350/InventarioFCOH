using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Auditorium
    {
        public int AuditoriaId { get; set; }
        public int EquipoId { get; set; }
        public DateTime FechaCambio { get; set; }
        public string Detalle { get; set; } = null!;

        public virtual Equipo Equipo { get; set; } = null!;
    }
}
