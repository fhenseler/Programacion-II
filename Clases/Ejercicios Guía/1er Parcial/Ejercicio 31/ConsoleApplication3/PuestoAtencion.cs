using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication3
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        Puesto puesto = new Puesto();

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        
        static PuestoAtencion()
        {
             numeroActual = 0;
        }

        public static int NumeroActual
	    {
            get { return NumeroActual++; }
            set { NumeroActual = value; }
	    }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1111);
            return true;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
