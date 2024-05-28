using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyecto.Models
{
    public partial class Haberes
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double SueldoBasico { get; set; }
        public string TipoAportacion { get; set; }

    }
}