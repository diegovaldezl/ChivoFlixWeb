using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Models
{
    public class DuracionPlanes
    {
        [Key]
        public int idDuracionPlanes { get; set; }
        public string nombre { get; set; }
    }
}
