using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Cheque
    {
        public int BancoId { get; set; }
        public string CuentaId { get; set; } = null!;
        public string? ChequeId { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Beneficiario { get; set; }
        public string? Descripcion { get; set; }
        public double? Valor { get; set; }
        public string? Estado { get; set; }
        public string? Tipo { get; set; }
        public double? Factor { get; set; }
        public int? ProveedorId { get; set; }
    }
}
