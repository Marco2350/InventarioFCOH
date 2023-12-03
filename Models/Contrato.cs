using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Contrato
    {
        public int ContratoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
