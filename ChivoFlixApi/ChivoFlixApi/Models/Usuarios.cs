using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Models
{
    public class Usuarios
    {
        [Key]
        public int idUsuarios { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int perfiles { get; set; }
        public string imagen { get; set; }
        public int idRol { get; set; }
        public int? idPlanes { get; set; }
    }
}
