// <auto-generated />
using System;
using ChivoFlixWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChivoFlixWeb.Migrations
{
    [DbContext(typeof(CHIVOFLIXContext))]
    [Migration("20220529013743_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChivoFlixWeb.Models.DuracionPlanes", b =>
                {
                    b.Property<int>("IdDuracionPlanes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idDuracionPlanes")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("nombre");

                    b.HasKey("IdDuracionPlanes")
                        .HasName("PK__duracion__812FA85D4DDDD2A5");

                    b.ToTable("duracionPlanes");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Facturaciones", b =>
                {
                    b.Property<int>("IdFacturaciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idFacturaciones")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FechaAdquirido")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaAdquirido");

                    b.Property<int>("IdPlanes")
                        .HasColumnType("int")
                        .HasColumnName("idPlanes");

                    b.Property<int>("IdUsuarios")
                        .HasColumnType("int")
                        .HasColumnName("idUsuarios");

                    b.Property<string>("Plann")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("plann");

                    b.Property<double>("Precio")
                        .HasColumnType("float")
                        .HasColumnName("precio");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("tipo");

                    b.Property<double>("Total")
                        .HasColumnType("float")
                        .HasColumnName("total");

                    b.HasKey("IdFacturaciones")
                        .HasName("PK__facturac__85C535F2A8D79B67");

                    b.HasIndex(new[] { "IdPlanes" }, "IX_facturaciones_idPlanes");

                    b.HasIndex(new[] { "IdUsuarios" }, "IX_facturaciones_idUsuarios");

                    b.ToTable("facturaciones");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Generos", b =>
                {
                    b.Property<int>("IdGeneros")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idGeneros")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nombre");

                    b.HasKey("IdGeneros")
                        .HasName("PK__generos__525F69B817391CE1");

                    b.ToTable("generos");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Listados", b =>
                {
                    b.Property<int>("IdListado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idListado")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPeliculas")
                        .HasColumnType("int")
                        .HasColumnName("idPeliculas");

                    b.Property<int>("IdUsuarios")
                        .HasColumnType("int")
                        .HasColumnName("idUsuarios");

                    b.HasKey("IdListado")
                        .HasName("PK__listados__EEA3B4650814573D");

                    b.HasIndex(new[] { "IdPeliculas" }, "IX_listados_idPeliculas");

                    b.HasIndex(new[] { "IdUsuarios" }, "IX_listados_idUsuarios");

                    b.ToTable("listados");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Peliculas", b =>
                {
                    b.Property<int>("IdPeliculas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idPeliculas")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnioEstreno")
                        .HasColumnType("int")
                        .HasColumnName("anioEstreno");

                    b.Property<string>("Banner")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("banner");

                    b.Property<string>("Calidad")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("calidad");

                    b.Property<string>("CategoriaEdad")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("categoriaEdad");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("director");

                    b.Property<int>("IdGeneros")
                        .HasColumnType("int")
                        .HasColumnName("idGeneros");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("nombre");

                    b.Property<string>("Pelicula1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pelicula");

                    b.HasKey("IdPeliculas")
                        .HasName("PK__pelicula__71DB443F16B1CBF9");

                    b.HasIndex(new[] { "IdGeneros" }, "IX_peliculas_idGeneros");

                    b.ToTable("peliculas");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Planes", b =>
                {
                    b.Property<int>("IdPlanes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idPlanes")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdDuracionPlanes")
                        .HasColumnType("int")
                        .HasColumnName("idDuracionPlanes");

                    b.Property<int>("IdUsuarios")
                        .HasColumnType("int")
                        .HasColumnName("idUsuarios");

                    b.Property<string>("Plann")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("plann");

                    b.Property<double>("PrecioPlan")
                        .HasColumnType("float")
                        .HasColumnName("precioPlan");

                    b.HasKey("IdPlanes")
                        .HasName("PK__planes__31C4681E538E7E4D");

                    b.HasIndex(new[] { "IdDuracionPlanes" }, "IX_planes_idDuracionPlanes");

                    b.HasIndex(new[] { "IdUsuarios" }, "IX_planes_idUsuarios");

                    b.ToTable("planes");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Roles", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idRol")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rol")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("rol");

                    b.HasKey("IdRol")
                        .HasName("PK__roles__3C872F76AB588757");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Usuarios", b =>
                {
                    b.Property<int>("IdUsuarios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idUsuarios")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("IdPlanes")
                        .HasColumnType("int")
                        .HasColumnName("idPlanes");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int")
                        .HasColumnName("idRol");

                    b.Property<string>("Imagen")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("imagen");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("password");

                    b.Property<int?>("Perfiles")
                        .HasColumnType("int")
                        .HasColumnName("perfiles");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("username");

                    b.HasKey("IdUsuarios")
                        .HasName("PK__usuarios__3940559A7C6EFA46");

                    b.HasIndex("IdPlanes");

                    b.HasIndex(new[] { "IdRol" }, "IX_usuarios_idRol");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Facturaciones", b =>
                {
                    b.HasOne("ChivoFlixWeb.Models.Planes", "IdPlanesNavigation")
                        .WithMany("Facturaciones")
                        .HasForeignKey("IdPlanes")
                        .HasConstraintName("fk_Facuraciones_Planes")
                        .IsRequired();

                    b.HasOne("ChivoFlixWeb.Models.Usuarios", "IdUsuariosNavigation")
                        .WithMany("Facturaciones")
                        .HasForeignKey("IdUsuarios")
                        .HasConstraintName("fk_Facturaciones_Usuarios")
                        .IsRequired();

                    b.Navigation("IdPlanesNavigation");

                    b.Navigation("IdUsuariosNavigation");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Listados", b =>
                {
                    b.HasOne("ChivoFlixWeb.Models.Peliculas", "IdPeliculasNavigation")
                        .WithMany("Listados")
                        .HasForeignKey("IdPeliculas")
                        .HasConstraintName("fk_Listado_Peliculas")
                        .IsRequired();

                    b.HasOne("ChivoFlixWeb.Models.Usuarios", "IdUsuariosNavigation")
                        .WithMany("Listados")
                        .HasForeignKey("IdUsuarios")
                        .HasConstraintName("fk_Listado_Usuarios")
                        .IsRequired();

                    b.Navigation("IdPeliculasNavigation");

                    b.Navigation("IdUsuariosNavigation");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Peliculas", b =>
                {
                    b.HasOne("ChivoFlixWeb.Models.Generos", "IdGenerosNavigation")
                        .WithMany("Peliculas")
                        .HasForeignKey("IdGeneros")
                        .HasConstraintName("fk_Peliculas_Generos")
                        .IsRequired();

                    b.Navigation("IdGenerosNavigation");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Planes", b =>
                {
                    b.HasOne("ChivoFlixWeb.Models.DuracionPlanes", "IdDuracionPlanesNavigation")
                        .WithMany("Planes")
                        .HasForeignKey("IdDuracionPlanes")
                        .HasConstraintName("fk_Planes_DuracionP")
                        .IsRequired();

                    b.HasOne("ChivoFlixWeb.Models.Usuarios", "IdUsuariosNavigation")
                        .WithMany("Planes")
                        .HasForeignKey("IdUsuarios")
                        .HasConstraintName("fk_Planes_Usuarios")
                        .IsRequired();

                    b.Navigation("IdDuracionPlanesNavigation");

                    b.Navigation("IdUsuariosNavigation");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Usuarios", b =>
                {
                    b.HasOne("ChivoFlixWeb.Models.Planes", "IdPlanesNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdPlanes")
                        .HasConstraintName("FK__usuarios__idPlan__34C8D9D1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChivoFlixWeb.Models.Roles", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("fk_Usuarios_Roles");

                    b.Navigation("IdPlanesNavigation");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.DuracionPlanes", b =>
                {
                    b.Navigation("Planes");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Generos", b =>
                {
                    b.Navigation("Peliculas");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Peliculas", b =>
                {
                    b.Navigation("Listados");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Planes", b =>
                {
                    b.Navigation("Facturaciones");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Roles", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ChivoFlixWeb.Models.Usuarios", b =>
                {
                    b.Navigation("Facturaciones");

                    b.Navigation("Listados");

                    b.Navigation("Planes");
                });
#pragma warning restore 612, 618
        }
    }
}
