using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Cuotum
    {
        public int CuotaId { get; set; }
        public int ContratoId { get; set; }
        public string Periodo { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
