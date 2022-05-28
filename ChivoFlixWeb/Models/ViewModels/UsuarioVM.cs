using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Models.ViewModels
{
    public class UsuarioVM
    {
        public UsuarioVM()
        {
            Facturaciones = new HashSet<Facturaciones>();
            Listados = new HashSet<Listados>();
            Planes = new HashSet<Planes>();
        }
        [Key]
        public int IdUsuarios { get; set; }

        [Required(ErrorMessage ="El usuario es requerido!")]
        [Display(Name = "Ingrese Usuario")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El correo es requerido!")]
        [EmailAddress]
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida!")]
        //[StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Ingrese Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage ="No Coinciden!")]
        //[StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Repita Contraseña")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Perfil")]
        public int? Perfiles { get; set; }

        [Required(ErrorMessage = "Ingrese una direccion valida!")]
        [Display(Name = "Imagen")]
        public string Imagen { get; set; }

        [Display(Name = "Rol")]
        public int? IdRol { get; set; }


        [Required(ErrorMessage = "Seleccione un plan!")]
        [Display(Name = "Seleccione un plan")]
        public int IdPlanes { get; set; }

        public virtual Planes IdPlanesNavigation { get; set; }
        public virtual Roles IdRolNavigation { get; set; }
        public virtual ICollection<Facturaciones> Facturaciones { get; set; }
        public virtual ICollection<Listados> Listados { get; set; }
        public virtual ICollection<Planes> Planes { get; set; }
    }
}
