using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Models
{
    public class Peliculas
    {
        [Key]
        public int idPeliculas { get; set; }
        public string nombre { get; set; }
        public int anioEstreno { get; set; }
        public string categoriaEdad { get; set; }
        public string descripcion { get; set; }
        public string calidad { get; set; }
        public string director { get; set; }
        public string banner { get; set; }
        public int idGeneros { get; set; }
        public string Pelicula { get; set; }
    }
}
