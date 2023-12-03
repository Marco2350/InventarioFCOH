using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public int Existencia { get; set; }
        public double Costo { get; set; }
        public int Almacen { get; set; }
    }
}
