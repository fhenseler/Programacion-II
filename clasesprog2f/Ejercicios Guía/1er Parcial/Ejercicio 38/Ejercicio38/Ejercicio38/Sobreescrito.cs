using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
             object aux = new Object();

             if (aux == obj)
                 return true;
             return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
