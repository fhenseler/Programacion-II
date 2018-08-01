using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Automovil : VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private short cantidadPasajeros;

        public Automovil(short cantMarchas, short cantPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            //base.cantidadPuertas = cantPuertas;
            //base.cantidadRuedas = cantRuedas;
            //base.color = color;
            this.cantidadPasajeros = cantPasajeros;
            this.cantidadMarchas = cantMarchas;
        }
    }
}
