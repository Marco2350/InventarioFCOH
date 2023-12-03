using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InventarioFCOH.Models
{
    public partial class DB20162000225Context : DbContext
    {
        public DB20162000225Context()
        {
        }

        public DB20162000225Context(DbContextOptions<DB20162000225Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacen> Almacens { get; set; } = null!;
        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        public virtual DbSet<Articulo> Articulos { get; set; } = null!;
        public virtual DbSet<Asignacione> Asignaciones { get; set; } = null!;
        public virtual DbSet<Auditorium> Auditoria { get; set; } = null!;
        public virtual DbSet<Bodega> Bodegas { get; set; } = null!;
        public virtual DbSet<Caracteristica> Caracteristicas { get; set; } = null!;
        public virtual DbSet<CaracteristicasDetalle> CaracteristicasDetalles { get; set; } = null!;
        public virtual DbSet<CaracteristicasEquipo> CaracteristicasEquipos { get; set; } = null!;
        public virtual DbSet<Carrera> Carreras { get; set; } = null!;
        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Cheque> Cheques { get; set; } = null!;
        public virtual DbSet<Clase> Clases { get; set; } = null!;
        public virtual DbSet<Clase1> Clases1 { get; set; } = null!;
        public virtual DbSet<ClaseMateriaMaestro> ClaseMateriaMaestros { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Contrato> Contratos { get; set; } = null!;
        public virtual DbSet<Cuotum> Cuota { get; set; } = null!;
        public virtual DbSet<Equipo> Equipos { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; } = null!;
        public virtual DbSet<HistoricoAsignacione> HistoricoAsignaciones { get; set; } = null!;
        public virtual DbSet<HistoricoEquipo> HistoricoEquipos { get; set; } = null!;
        public virtual DbSet<Kevin> Kevins { get; set; } = null!;
        public virtual DbSet<Maestro> Maestros { get; set; } = null!;
        public virtual DbSet<Mantenimiento> Mantenimientos { get; set; } = null!;
        public virtual DbSet<Marca> Marcas { get; set; } = null!;
        public virtual DbSet<Materium> Materia { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<ReporteEquipoTotalPorCategoriaEstado> ReporteEquipoTotalPorCategoriaEstados { get; set; } = null!;
        public virtual DbSet<Saldo> Saldos { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<Title> Titles { get; set; } = null!;
        public virtual DbSet<Ubicacione> Ubicaciones { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<VRegristro> VRegristros { get; set; } = null!;
        public virtual DbSet<VwDamagedEquipmentReport> VwDamagedEquipmentReports { get; set; } = null!;
        public virtual DbSet<VwHistoricalReport> VwHistoricalReports { get; set; } = null!;
        public virtual DbSet<VwReporteEquipoTotalCategoriaEstado> VwReporteEquipoTotalCategoriaEstados { get; set; } = null!;
        public virtual DbSet<VwReporteEquipoTotalCategoriaEstado1> VwReporteEquipoTotalCategoriaEstados1 { get; set; } = null!;
        public virtual DbSet<VwReporteEquipoTotalPorCategoriaEstado> VwReporteEquipoTotalPorCategoriaEstados { get; set; } = null!;
        public virtual DbSet<VwReporteGeneralInventario> VwReporteGeneralInventarios { get; set; } = null!;
        public virtual DbSet<VwReporteInventarioHistorico> VwReporteInventarioHistoricos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:3.128.144.165;Database=DB20162000225;User ID=kevin.antunez;Password=KA20162000225;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Almacen");

                entity.Property(e => e.AlmacenId).HasColumnName("AlmacenID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alumno");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sexo");
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("articulo");

                entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");

                entity.Property(e => e.Barra)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.ClaseId).HasColumnName("ClaseID");

                entity.Property(e => e.MarcaId).HasColumnName("MarcaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");
            });

            modelBuilder.Entity<Asignacione>(entity =>
            {
                entity.HasKey(e => e.AsignacionId)
                    .HasName("PK_AsignacionesEquipo");

                entity.ToTable("asignaciones", "inventario");

                entity.Property(e => e.AsignacionId).HasColumnName("asignacionID");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAsignacion");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioID");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsignacionesEquipo_Equipo");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsignacionesEquipo_Usuarios");
            });

            modelBuilder.Entity<Auditorium>(entity =>
            {
                entity.HasKey(e => e.AuditoriaId)
                    .HasName("PK__auditori__ED6C0FDB33191C1C");

                entity.ToTable("auditoria", "inventario");

                entity.Property(e => e.AuditoriaId).HasColumnName("auditoriaID");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(255)
                    .HasColumnName("detalle");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.FechaCambio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCambio");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.Auditoria)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_auditoria_Equipo$EquipoID");
            });

            modelBuilder.Entity<Bodega>(entity =>
            {
                entity.ToTable("bodega");

                entity.Property(e => e.BodegaId)
                    .ValueGeneratedNever()
                    .HasColumnName("bodegaId");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Caracteristica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("caracteristicas", "inventario");

                entity.Property(e => e.CaracteristicaId).HasColumnName("caracteristicaID");

                entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");

                entity.HasOne(d => d.CaracteristicaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CaracteristicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_caracteristicas_caracteristicasDetalle$caracteristicaID");

                entity.HasOne(d => d.Categoria)
                    .WithMany()
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_caracteristicas_Categorias$CategoriaID");
            });

            modelBuilder.Entity<CaracteristicasDetalle>(entity =>
            {
                entity.HasKey(e => e.CaracteristicaId)
                    .HasName("Pk_carateristicaDetalle");

                entity.ToTable("caracteristicasDetalle", "inventario");

                entity.Property(e => e.CaracteristicaId).HasColumnName("caracteristicaID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<CaracteristicasEquipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("caracteristicasEquipo", "inventario");

                entity.Property(e => e.CaracteristicaId).HasColumnName("caracteristicaID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.HasOne(d => d.Caracteristica)
                    .WithMany()
                    .HasForeignKey(d => d.CaracteristicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaracteristicasEquipo_caracteristicas");

                entity.HasOne(d => d.Equipo)
                    .WithMany()
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaracteristicasEquipo_Equipo");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Carrera");

                entity.Property(e => e.CarreraId).HasColumnName("carreraId");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.ToTable("categorias", "inventario");

                entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cheque");

                entity.Property(e => e.BancoId).HasColumnName("BancoID");

                entity.Property(e => e.Beneficiario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.ChequeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ChequeID");

                entity.Property(e => e.CuentaId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CuentaID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Clase");

                entity.Property(e => e.ClaseId).HasColumnName("ClaseID");

                entity.Property(e => e.Horario)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaestroId).HasColumnName("MaestroID");

                entity.Property(e => e.MateriaId).HasColumnName("MateriaID");
            });

            modelBuilder.Entity<Clase1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Clases");

                entity.Property(e => e.ClaseId).HasColumnName("ClaseID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<ClaseMateriaMaestro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaseMateriaMaestro");

                entity.Property(e => e.ClaseId).HasColumnName("ClaseID");

                entity.Property(e => e.MaestroId).HasColumnName("MaestroID");

                entity.Property(e => e.MaestroNom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MateriaId).HasColumnName("MateriaID");

                entity.Property(e => e.MateriaNom)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cliente");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contrato");

                entity.Property(e => e.ClienteId).HasColumnName("clienteID");

                entity.Property(e => e.ContratoId).HasColumnName("contratoID");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");
            });

            modelBuilder.Entity<Cuotum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cuota");

                entity.Property(e => e.ContratoId).HasColumnName("contratoID");

                entity.Property(e => e.CuotaId).HasColumnName("cuotaID");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("periodo");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.ToTable("equipo", "inventario");

                entity.HasIndex(e => e.Serie, "uk_serie")
                    .IsUnique();

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");

                entity.Property(e => e.DescripcionGeneral)
                    .HasMaxLength(150)
                    .HasColumnName("descripcionGeneral");

                entity.Property(e => e.EstadoId).HasColumnName("estadoID");

                entity.Property(e => e.FechaAdquisicion)
                    .HasColumnType("date")
                    .HasColumnName("fechaAdquisicion");

                entity.Property(e => e.PrecioAdquisicion).HasColumnName("precioAdquisicion");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedorID");

                entity.Property(e => e.Serie)
                    .HasMaxLength(75)
                    .HasColumnName("serie");

                entity.Property(e => e.UbicacionId).HasColumnName("ubicacionID");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Equipo_Categorias$CategoriaID");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Equipo_Estados$EstadoID");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.ProveedorId)
                    .HasConstraintName("Fk_Equipo_Proveedores$ProveedorID");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.UbicacionId)
                    .HasConstraintName("Fk_Equipo_Ubicaciones$UbicacionID");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estados", "inventario");

                entity.Property(e => e.EstadoId).HasColumnName("estadoID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Factura");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.FacturaId).HasColumnName("FacturaID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("facturaDetalle");

                entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");

                entity.Property(e => e.FacturaId).HasColumnName("FacturaID");

                entity.Property(e => e.Isv).HasColumnName("ISV");
            });

            modelBuilder.Entity<HistoricoAsignacione>(entity =>
            {
                entity.HasKey(e => e.HistoricoId)
                    .HasName("PK_HistoricoAsignaciones");

                entity.ToTable("historicoAsignaciones", "inventario");

                entity.Property(e => e.HistoricoId).HasColumnName("historicoID");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAsignacion");

                entity.Property(e => e.FechaDesasignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesasignacion");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioID");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.HistoricoAsignaciones)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoAsignaciones_Equipo");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.HistoricoAsignaciones)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoAsignaciones_Usuarios");
            });

            modelBuilder.Entity<HistoricoEquipo>(entity =>
            {
                entity.HasKey(e => e.HistoricoId)
                    .HasName("PK__historic__22DB9B9534B0A4A0");

                entity.ToTable("historicoEquipos", "inventario");

                entity.Property(e => e.HistoricoId).HasColumnName("historicoID");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(255)
                    .HasColumnName("motivo");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.HistoricoEquipos)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Equipo_historicoEquipo_equipoID");
            });

            modelBuilder.Entity<Kevin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kevin");

                entity.Property(e => e.Clases)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("clases");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Unidades)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("unidades");
            });

            modelBuilder.Entity<Maestro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Maestro");

                entity.Property(e => e.MaestroId).HasColumnName("MaestroID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mantenimiento>(entity =>
            {
                entity.ToTable("mantenimiento", "inventario");

                entity.Property(e => e.MantenimientoId).HasColumnName("mantenimientoID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.FechaMantenimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaMantenimiento");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.Mantenimientos)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mantenimiento_Equipo$EquipoID");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("marca");

                entity.Property(e => e.MarcaId).HasColumnName("MarcaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");
            });

            modelBuilder.Entity<Materium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MateriaId).HasColumnName("MateriaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Uv).HasColumnName("UV");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Producto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.ProveedorId)
                    .HasName("PK__proveedo__825325BD251062ED");

                entity.ToTable("proveedores", "inventario");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedorID");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(255)
                    .HasColumnName("contacto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ReporteEquipoTotalPorCategoriaEstado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("reporte_EquipoTotalPorCategoriaEstado", "inventario");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EnReparacion).HasColumnName("En reparacion");

                entity.Property(e => e.FueraDeServicio).HasColumnName("Fuera de Servicio");

                entity.Property(e => e.TotalExistencias).HasColumnName("Total Existencias");
            });

            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.HasKey(e => e.ProveedorId)
                    .HasName("pksaldo");

                entity.ToTable("saldo");

                entity.Property(e => e.ProveedorId)
                    .ValueGeneratedNever()
                    .HasColumnName("proveedorId");

                entity.Property(e => e.Saldo1).HasColumnName("saldo");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SALES");

                entity.Property(e => e.OrdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ord_date");

                entity.Property(e => e.OrdNum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ord_num");

                entity.Property(e => e.Payterms)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("payterms");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.StorId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("stor_id")
                    .IsFixedLength();

                entity.Property(e => e.TitleId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("title_id");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TITLES");

                entity.Property(e => e.Advance)
                    .HasColumnType("money")
                    .HasColumnName("advance");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.PubId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pub_id")
                    .IsFixedLength();

                entity.Property(e => e.Pubdate)
                    .HasColumnType("datetime")
                    .HasColumnName("pubdate");

                entity.Property(e => e.Royalty).HasColumnName("royalty");

                entity.Property(e => e.Title1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.TitleId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("title_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("type")
                    .IsFixedLength();

                entity.Property(e => e.YtdSales).HasColumnName("ytd_sales");
            });

            modelBuilder.Entity<Ubicacione>(entity =>
            {
                entity.HasKey(e => e.UbicacionId)
                    .HasName("PK__ubicacio__6A9B4B9B9B1B00F9");

                entity.ToTable("ubicaciones", "inventario");

                entity.Property(e => e.UbicacionId).HasColumnName("ubicacionID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuarios", "inventario");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VRegristro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRegristro");

                entity.Property(e => e.CarreraId).HasColumnName("carreraId");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VwDamagedEquipmentReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DamagedEquipmentReport", "inventario");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .HasColumnName("categoria");

                entity.Property(e => e.DescripcionMantenimiento)
                    .HasMaxLength(255)
                    .HasColumnName("descripcionMantenimiento");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaMantenimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaMantenimiento");

                entity.Property(e => e.FechaReparacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaReparacion");

                entity.Property(e => e.FechaReporte)
                    .HasColumnType("date")
                    .HasColumnName("fechaReporte");
            });

            modelBuilder.Entity<VwHistoricalReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HistoricalReport", "inventario");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFinal");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.NombreEquipo)
                    .HasMaxLength(150)
                    .HasColumnName("nombreEquipo");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(100)
                    .HasColumnName("nombreUsuario");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioID");
            });

            modelBuilder.Entity<VwReporteEquipoTotalCategoriaEstado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_reporteEquipoTotalCategoriaEstado");

                entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<VwReporteEquipoTotalCategoriaEstado1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_reporteEquipoTotalCategoriaEstado", "inventario");

                entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<VwReporteEquipoTotalPorCategoriaEstado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_reporteEquipoTotalPorCategoriaEstado", "inventario");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EnReparacion).HasColumnName("En reparacion");

                entity.Property(e => e.FueraDeServicio).HasColumnName("Fuera de Servicio");

                entity.Property(e => e.TotalExistencias).HasColumnName("Total Existencias");
            });

            modelBuilder.Entity<VwReporteGeneralInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_reporteGeneralInventario", "inventario");

                entity.Property(e => e.DescripcionGeneral)
                    .HasMaxLength(150)
                    .HasColumnName("descripcionGeneral");

                entity.Property(e => e.EquipoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("equipoID");

                entity.Property(e => e.FechaDeCompra)
                    .HasMaxLength(4000)
                    .HasColumnName("Fecha de compra");

                entity.Property(e => e.PrecioDeCompra)
                    .HasMaxLength(4000)
                    .HasColumnName("Precio de compra");
            });

            modelBuilder.Entity<VwReporteInventarioHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_reporteInventarioHistorico", "inventario");

                entity.Property(e => e.EquipoId).HasColumnName("equipoID");

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAsignacion");

                entity.Property(e => e.FechaDesasignacionFormateada)
                    .HasMaxLength(4000)
                    .HasColumnName("fechaDesasignacionFormateada");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
