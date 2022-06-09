using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixApi.Models
{
    public class Facturaciones
    {
        [Key]
        public int idFacturaciones { get; set; }
        public int idUsuarios { get; set; }
        public int idPlanes { get; set; }
        public string plann { get; set; }
        public DateTime fechaAdquirido { get; set; }
        public string tipo { get; set; }
        public double precio { get; set; }
        public double total { get; set; }
    }
}
