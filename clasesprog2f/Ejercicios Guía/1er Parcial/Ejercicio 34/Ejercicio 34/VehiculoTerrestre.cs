using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        public VehiculoTerrestre(short cantRuedas, short cantPuertas, Colores color)
        {
            this.cantidadPuertas = cantPuertas;
            this.cantidadRuedas = cantRuedas;
            this.color = color;
        }
    }
}
