using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Equipos = new HashSet<Equipo>();
        }

        public int ProveedorId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Contacto { get; set; } = null!;

        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
