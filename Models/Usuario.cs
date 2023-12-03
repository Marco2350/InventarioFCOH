using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Asignaciones = new HashSet<Asignacione>();
            HistoricoAsignaciones = new HashSet<HistoricoAsignacione>();
        }

        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Asignacione> Asignaciones { get; set; }
        public virtual ICollection<HistoricoAsignacione> HistoricoAsignaciones { get; set; }
    }
}
