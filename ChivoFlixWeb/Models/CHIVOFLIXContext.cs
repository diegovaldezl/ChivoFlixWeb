using System;
using System.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ChivoFlixWeb.Models
{
    public partial class CHIVOFLIXContext : DbContext
    {
        public CHIVOFLIXContext()
        {
        }

        public CHIVOFLIXContext(DbContextOptions<CHIVOFLIXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DuracionPlanes> DuracionPlanes { get; set; }
        public virtual DbSet<Facturaciones> Facturaciones { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Listados> Listados { get; set; }
        public virtual DbSet<Peliculas> Peliculas { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<DuracionPlanes>(entity =>
            {
                entity.HasKey(e => e.IdDuracionPlanes)
                    .HasName("PK__duracion__812FA85D4DDDD2A5");

                entity.ToTable("duracionPlanes");

                entity.Property(e => e.IdDuracionPlanes).HasColumnName("idDuracionPlanes");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Facturaciones>(entity =>
            {
                entity.HasKey(e => e.IdFacturaciones)
                    .HasName("PK__facturac__85C535F2A8D79B67");

                entity.ToTable("facturaciones");

                entity.HasIndex(e => e.IdPlanes, "IX_facturaciones_idPlanes");

                entity.HasIndex(e => e.IdUsuarios, "IX_facturaciones_idUsuarios");

                entity.Property(e => e.IdFacturaciones).HasColumnName("idFacturaciones");

                entity.Property(e => e.FechaAdquirido)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAdquirido");

                entity.Property(e => e.IdPlanes).HasColumnName("idPlanes");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Plann)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("plann");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdPlanesNavigation)
                    .WithMany(p => p.Facturaciones)
                    .HasForeignKey(d => d.IdPlanes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Facuraciones_Planes");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Facturaciones)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Facturaciones_Usuarios");
            });

            modelBuilder.Entity<Generos>(entity =>
            {
                entity.HasKey(e => e.IdGeneros)
                    .HasName("PK__generos__525F69B817391CE1");

                entity.ToTable("generos");

                entity.Property(e => e.IdGeneros).HasColumnName("idGeneros");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Listados>(entity =>
            {
                entity.HasKey(e => e.IdListado)
                    .HasName("PK__listados__EEA3B4650814573D");

                entity.ToTable("listados");

                entity.HasIndex(e => e.IdPeliculas, "IX_listados_idPeliculas");

                entity.HasIndex(e => e.IdUsuarios, "IX_listados_idUsuarios");

                entity.Property(e => e.IdListado).HasColumnName("idListado");

                entity.Property(e => e.IdPeliculas).HasColumnName("idPeliculas");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.HasOne(d => d.IdPeliculasNavigation)
                    .WithMany(p => p.Listados)
                    .HasForeignKey(d => d.IdPeliculas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Listado_Peliculas");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Listados)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Listado_Usuarios");
            });

            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.HasKey(e => e.IdPeliculas)
                    .HasName("PK__pelicula__71DB443F16B1CBF9");

                entity.ToTable("peliculas");

                entity.HasIndex(e => e.IdGeneros, "IX_peliculas_idGeneros");

                entity.Property(e => e.IdPeliculas).HasColumnName("idPeliculas");

                entity.Property(e => e.AnioEstreno).HasColumnName("anioEstreno");

                entity.Property(e => e.Banner)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("banner");

                entity.Property(e => e.Calidad)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("calidad");

                entity.Property(e => e.CategoriaEdad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("categoriaEdad");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("director");

                entity.Property(e => e.IdGeneros).HasColumnName("idGeneros");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pelicula1).HasColumnName("Pelicula");

                entity.HasOne(d => d.IdGenerosNavigation)
                    .WithMany(p => p.Peliculas)
                    .HasForeignKey(d => d.IdGeneros)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Peliculas_Generos");
            });

            modelBuilder.Entity<Planes>(entity =>
            {
                entity.HasKey(e => e.IdPlanes)
                    .HasName("PK__planes__31C4681E538E7E4D");

                entity.ToTable("planes");

                entity.HasIndex(e => e.IdDuracionPlanes, "IX_planes_idDuracionPlanes");

                entity.HasIndex(e => e.IdUsuarios, "IX_planes_idUsuarios");

                entity.Property(e => e.IdPlanes).HasColumnName("idPlanes");

                entity.Property(e => e.IdDuracionPlanes).HasColumnName("idDuracionPlanes");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Plann)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("plann");

                entity.Property(e => e.PrecioPlan).HasColumnName("precioPlan");

                entity.HasOne(d => d.IdDuracionPlanesNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdDuracionPlanes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Planes_DuracionP");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Planes_Usuarios");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__roles__3C872F76AB588757");

                entity.ToTable("roles");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Rol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rol");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PK__usuarios__3940559A7C6EFA46");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdRol, "IX_usuarios_idRol");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdPlanes).HasColumnName("idPlanes");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Imagen)
                    .IsUnicode(false)
                    .HasColumnName("imagen");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Perfiles).HasColumnName("perfiles");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdPlanesNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPlanes)
                    .HasConstraintName("FK__usuarios__idPlan__34C8D9D1");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("fk_Usuarios_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
