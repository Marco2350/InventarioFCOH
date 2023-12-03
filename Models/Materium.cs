using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Materium
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; } = null!;
        public int Uv { get; set; }
    }
}
