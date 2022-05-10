using System;
using System.Collections.Generic;

#nullable disable

namespace ChivoFlixWeb.Models
{
    public partial class Listados
    {
        public int IdListado { get; set; }
        public int IdPeliculas { get; set; }
        public int IdUsuarios { get; set; }

        public virtual Peliculas IdPeliculasNavigation { get; set; }
        public virtual Usuarios IdUsuariosNavigation { get; set; }
    }
}
