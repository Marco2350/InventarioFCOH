using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class VwReporteEquipoTotalPorCategoriaEstado
    {
        public string Descripcion { get; set; } = null!;
        public int? Disponible { get; set; }
        public int? EnReparacion { get; set; }
        public int? FueraDeServicio { get; set; }
        public int? TotalExistencias { get; set; }
    }
}
