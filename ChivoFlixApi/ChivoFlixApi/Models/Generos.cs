using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Models
{
    public class Generos
    {
        [Key]
        public int idGeneros { get; set; }
        public string nombre { get; set; }
    }
}
