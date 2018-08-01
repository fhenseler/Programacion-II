using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Negocio
    {
        public string nombre;
        Queue<Cliente> clientes;
        PuestoAtencion caja;

        private Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }
            set { this.clientes.Enqueue(value);}
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool value = false;
            Queue<Cliente> clientes = new Queue<Cliente>();
            if (!(n.clientes.Contains(c)))
            {
                clientes.Enqueue(c);
                value = true;
            }
            return value;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool value;

            if (n.clientes.Contains(c))
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return true;
        }

        public static bool operator ~(Negocio n)
        { 
            return true;
        }

    }
}
