using System;
using System.Collections.Generic;

#nullable disable

namespace ChivoFlixWeb.Models
{
    public partial class Facturaciones
    {
        public int IdFacturaciones { get; set; }
        public int IdUsuarios { get; set; }
        public int IdPlanes { get; set; }
        public string Plann { get; set; }
        public DateTime? FechaAdquirido { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public virtual Planes IdPlanesNavigation { get; set; }
        public virtual Usuarios IdUsuariosNavigation { get; set; }
    }
}
