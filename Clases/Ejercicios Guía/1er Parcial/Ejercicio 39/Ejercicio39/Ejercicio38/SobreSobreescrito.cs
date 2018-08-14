using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class SobreSobreescrito : Sobreescrito
    {
        public override string MiPropiedad
        {
            get { return this.miAtributo; }
        }

        public override string miMetodo()
        {
            return "Método sobreescrito";
        }
    }
}
