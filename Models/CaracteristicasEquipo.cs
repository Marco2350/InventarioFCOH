using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class CaracteristicasEquipo
    {
        public int EquipoId { get; set; }
        public int CaracteristicaId { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual CaracteristicasDetalle Caracteristica { get; set; } = null!;
        public virtual Equipo Equipo { get; set; } = null!;
    }
}
