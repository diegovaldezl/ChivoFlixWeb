using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Id")]
        public int IdUsuarios { get; set; }
        [Display(Name = "Usuario")]
        public string Username { get; set; }
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Perfiles { get; set; }
        public string Imagen { get; set; }
        public int? IdRol { get; set; }
        public int IdPlanes { get; set; }

        [Display(Name = "Plan")]
        public Planes IdPlanesNavigation { get; set; }

        [Display(Name = "Rol")]
        public Roles IdRolNavigation { get; set; }
        public virtual ICollection<Facturaciones> Facturaciones { get; set; }
        public virtual ICollection<Listados> Listados { get; set; }
        public virtual ICollection<Planes> Planes { get; set; }
    }
}
