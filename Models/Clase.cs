using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Clase
    {
        public int ClaseId { get; set; }
        public int MateriaId { get; set; }
        public int MaestroId { get; set; }
        public string Horario { get; set; } = null!;
    }
}
