using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class VwDamagedEquipmentReport
    {
        public int EquipoId { get; set; }
        public string Categoria { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaReporte { get; set; }
        public DateTime FechaReparacion { get; set; }
        public string DescripcionMantenimiento { get; set; } = null!;
        public DateTime FechaMantenimiento { get; set; }
    }
}
