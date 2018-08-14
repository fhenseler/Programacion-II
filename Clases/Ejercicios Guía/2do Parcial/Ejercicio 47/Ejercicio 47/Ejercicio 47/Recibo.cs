using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Recibo : Documento
    {
        public Recibo()
        {
            this.numero = 0;
        }

        public Recibo(int numero)
            : this()
        {
            this.numero = numero;
        }
    }
}
