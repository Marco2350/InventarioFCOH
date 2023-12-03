using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Sexo { get; set; } = null!;
    }
}
