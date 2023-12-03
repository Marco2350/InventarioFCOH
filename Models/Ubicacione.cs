using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Ubicacione
    {
        public Ubicacione()
        {
            Equipos = new HashSet<Equipo>();
        }

        public int UbicacionId { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
