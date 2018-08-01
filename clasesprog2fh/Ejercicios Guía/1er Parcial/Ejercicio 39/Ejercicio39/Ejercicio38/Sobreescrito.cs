using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public virtual string MiPropiedad
        {
            get { return this.miAtributo; }
        }

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

        public virtual string miMetodo()
        {
            return "";
        }
    }
}
