using System;
using System.Collections.Generic;

#nullable disable

namespace ChivoFlixWeb.Models
{
    public partial class DuracionPlanes
    {
        public DuracionPlanes()
        {
            Planes = new HashSet<Planes>();
        }

        public int IdDuracionPlanes { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Planes> Planes { get; set; }
    }
}
