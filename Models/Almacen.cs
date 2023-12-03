using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Almacen
    {
        public int AlmacenId { get; set; }
        public string Nombre { get; set; } = null!;
        public double Inventario { get; set; }
    }
}
