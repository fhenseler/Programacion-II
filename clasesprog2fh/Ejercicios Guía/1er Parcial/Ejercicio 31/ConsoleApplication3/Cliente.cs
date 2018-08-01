using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Cliente
    {
        public string nombre;
        public int numero;

        public static string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public static int Numero
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public Cliente(int numero, string nombre) :this(numero)
        {
            this.nombre = nombre;
        }

        public Cliente(int numero)
        {
             this.numero = numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            bool value;

            if (c1.numero != c2.numero)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool value;

            if (c1.numero == c2.numero)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }
    }
            

}
