using System;
using System.Collections.Generic;

namespace InventarioFCOH.Models
{
    public partial class Equipo
    {
        public Equipo()
        {
            Asignaciones = new HashSet<Asignacione>();
            Auditoria = new HashSet<Auditorium>();
            HistoricoAsignaciones = new HashSet<HistoricoAsignacione>();
            HistoricoEquipos = new HashSet<HistoricoEquipo>();
            Mantenimientos = new HashSet<Mantenimiento>();
        }

        public int EquipoId { get; set; }
        public int CategoriaId { get; set; }
        public int EstadoId { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public double PrecioAdquisicion { get; set; }
        public int? UbicacionId { get; set; }
        public int? ProveedorId { get; set; }
        public string? DescripcionGeneral { get; set; }
        public string? Serie { get; set; }
        public string CodigoEquipo { get; set; }

        public virtual Categoria Categoria { get; set; } = null!;
        public virtual Estado Estado { get; set; } = null!;
        public virtual Proveedore? Proveedor { get; set; }
        public virtual Ubicacione? Ubicacion { get; set; }
        public virtual ICollection<Asignacione> Asignaciones { get; set; }
        public virtual ICollection<Auditorium> Auditoria { get; set; }
        public virtual ICollection<HistoricoAsignacione> HistoricoAsignaciones { get; set; }
        public virtual ICollection<HistoricoEquipo> HistoricoEquipos { get; set; }
        public virtual ICollection<Mantenimiento> Mantenimientos { get; set; }
    }
}
