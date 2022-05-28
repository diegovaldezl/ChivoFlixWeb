using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Models.ViewModels
{
    public class PeliculaVM
    {
        public PeliculaVM()
        {
        }

        public int IdPeliculas { get; set; }

        [Required(ErrorMessage = "El nombre es requerido!")]
        [Display(Name = "Ingrese el nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El año de estreno es requerido!")]
        [Display(Name = "Año de estreno")]
        public int anioEstreno { get; set; }

        [Required(ErrorMessage = "La categoria es requerida!")]
        [Display(Name = "Ingrese la categoria")]
        public string categoriaEdad { get; set; }

        [Required(ErrorMessage = "La descripción es requerida!")]
        //[StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [Display(Name = "Ingrese la descripción")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "La calidad es requerida!")]
        [Display(Name = "Ingrese la calidad")]
        public string calidad { get; set; }

        [Required(ErrorMessage = "El director es requerido!")]
        [StringLength(maximumLength:20, ErrorMessage = "No puede exceder de 20 caracteres", MinimumLength = 5)]
        [Display(Name = "Ingrese el director")]
        public string director { get; set; }

        [Required(ErrorMessage = "El banner es requerido!")]
        [Display(Name = "Ingrese el banner")]
        public string banner { get; set; }

        [Required(ErrorMessage = "El genero es requerido!")]
        [Display(Name = "Seleccione un genero")]
        public int idGeneros { get; set; }

        [Required(ErrorMessage = "Ellink es requerido!")]
        [Display(Name = "Ingrese el link")]
        public string Pelicula { get; set; }


        public virtual Generos IdGenerosNavigation { get; set; }
    }
}
