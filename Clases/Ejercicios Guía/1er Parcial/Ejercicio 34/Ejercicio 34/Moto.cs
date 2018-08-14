using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Moto : VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cilindrada;

        public Moto(short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            //this.cantidadPuertas = cantPuertas;
            //this.cantidadRuedas = cantRuedas;
            //this.color = color;
            this.cilindrada = cilindrada;
        }
    }
}
