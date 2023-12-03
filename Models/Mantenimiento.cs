using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Mantenimiento
    {
        public int MantenimientoId { get; set; }
        public int EquipoId { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual Equipo Equipo { get; set; } = null!;
    }
}
