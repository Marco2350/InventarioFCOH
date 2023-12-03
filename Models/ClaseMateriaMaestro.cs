using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class ClaseMateriaMaestro
    {
        public int ClaseId { get; set; }
        public int MateriaId { get; set; }
        public string MateriaNom { get; set; } = null!;
        public int MaestroId { get; set; }
        public string MaestroNom { get; set; } = null!;
    }
}
