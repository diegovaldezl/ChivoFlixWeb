using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Models.ViewModels
{
    public class GenerosVM
    {
        public GenerosVM()
        {
           
        }
        [Key]
        public int IdGeneros { get; set; }

        [Required(ErrorMessage = "El nombre es requerido!")]
        [Display(Name = "Ingrese categoria")]
        public string Nombre { get; set; }

        public virtual ICollection<Peliculas> Peliculas { get; set; }


    }
}
