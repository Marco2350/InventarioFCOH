using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Articulo
    {
        public int ArticuloId { get; set; }
        public string? Nombre { get; set; }
        public int? TipoId { get; set; }
        public int? MarcaId { get; set; }
        public int? ClaseId { get; set; }
        public string? Barra { get; set; }
    }
}
