using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Caracteristica
    {
        public int CategoriaId { get; set; }
        public int CaracteristicaId { get; set; }

        public virtual CaracteristicasDetalle CaracteristicaNavigation { get; set; } = null!;
        public virtual Categoria Categoria { get; set; } = null!;
    }
}
