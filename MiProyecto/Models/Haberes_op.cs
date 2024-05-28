using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyecto.Models
{
    public partial class Haberes
    {
        public double Bonificacion() {
            return SueldoBasico * 0.25;
        }

        public double Remuneracion() {
            return SueldoBasico + Bonificacion();
        }

        public double Aportacion() {
            if (TipoAportacion == "AFP") {
                return Remuneracion() * 0.11;
            }
            if (TipoAportacion == "ONP") {
                return Remuneracion() * 0.13;
            }
            else {
                return 0;
            }
        }

        public double Neto() {
            return Remuneracion() - Aportacion();
        }
    }
}