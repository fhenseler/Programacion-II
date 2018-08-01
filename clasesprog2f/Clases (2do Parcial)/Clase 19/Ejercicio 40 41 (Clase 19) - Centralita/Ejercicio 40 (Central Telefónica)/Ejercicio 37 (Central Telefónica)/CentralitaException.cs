using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public class CentralitaException : Exception
    {
        public string nombreClase;
        public string nombreMetodo;

        public Exception ExcepcionInterna
        {
            get
            {
                return this.InnerException;
            }
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
            :base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : this(mensaje, clase, metodo)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
