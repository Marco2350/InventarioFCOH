using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Cliente
    {
        public int ClienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
    }
}
