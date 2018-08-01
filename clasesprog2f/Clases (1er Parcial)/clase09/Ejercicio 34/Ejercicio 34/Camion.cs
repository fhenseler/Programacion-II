using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantMarchas, int pesoCarga) 
            :base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
