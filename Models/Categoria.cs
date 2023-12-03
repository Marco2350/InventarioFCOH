using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Equipos = new HashSet<Equipo>();
        }

        public int CategoriaId { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
