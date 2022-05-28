using System;
using System.Collections.Generic;

#nullable disable

namespace ChivoFlixWeb.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Facturaciones = new HashSet<Facturaciones>();
            Listados = new HashSet<Listados>();
            Planes = new HashSet<Planes>();
        }

        public int IdUsuarios { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Perfiles { get; set; }
        public string Imagen { get; set; }
        public int? IdRol { get; set; }
        public int IdPlanes { get; set; }

        public virtual Planes IdPlanesNavigation { get; set; }
        public virtual Roles IdRolNavigation { get; set; }
        public virtual ICollection<Facturaciones> Facturaciones { get; set; }
        public virtual ICollection<Listados> Listados { get; set; }
        public virtual ICollection<Planes> Planes { get; set; }
    }
}
