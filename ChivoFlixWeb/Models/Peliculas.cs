using System;
using System.Collections.Generic;

#nullable disable

namespace ChivoFlixWeb.Models
{
    public partial class Peliculas
    {
        public Peliculas()
        {
            Listados = new HashSet<Listados>();
        }

        public int IdPeliculas { get; set; }
        public string Nombre { get; set; }
        public int AnioEstreno { get; set; }
        public string CategoriaEdad { get; set; }
        public string Descripcion { get; set; }
        public string Calidad { get; set; }
        public string Director { get; set; }
        public string Banner { get; set; }
        public int IdGeneros { get; set; }
        public string Pelicula1 { get; set; }

        public virtual Generos IdGenerosNavigation { get; set; }
        public virtual ICollection<Listados> Listados { get; set; }
    }
}
