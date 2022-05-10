using System;
using System.Collections.Generic;

#nullable disable

namespace ChivoFlixWeb.Models
{
    public partial class Generos
    {
        public Generos()
        {
            Peliculas = new HashSet<Peliculas>();
        }

        public int IdGeneros { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Peliculas> Peliculas { get; set; }
    }
}
