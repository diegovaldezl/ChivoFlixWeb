using ChivoFlixApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<DuracionPlanes> duracionPlanes { get; set; }
        public DbSet<Facturaciones> facturaciones { get; set; }
        public DbSet<Generos> generos { get; set; }
        public DbSet<Peliculas> peliculas { get; set; }
        public DbSet<Planes> planes { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }

    }
}
