using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Equipos = new HashSet<Equipo>();
        }

        public int EstadoId { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
