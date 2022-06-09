using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Models
{
    public class Planes
    {
        [Key]
        public int idPlanes { get; set; }
        public string plann { get; set; }
        public double precioPlan { get; set; }
        public int idDuracionPlanes { get; set; }
        public int idUsuarios { get; set; }
    }
}
