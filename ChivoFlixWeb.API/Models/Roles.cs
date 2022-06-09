using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Models
{
    public class Roles
    {
        [Key]
        public int idRol { get; set; }
        public string rol { get; set; }

    }
}
