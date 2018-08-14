using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Sumador
    {
        private int cantidadSumas;

        // Constructor that takes one argument.
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        // Constructor that takes no arguments.
        public Sumador() : this(0)
        {
        }

        // Method
        public long Sumar(long a, long b)
        {
            long resultado = a + b;
            cantidadSumas++;
            return resultado;
        }
        public string Sumar(string a, string b)
        {
            string retorno = String.Concat(a, b);
            cantidadSumas += 1;
            return retorno;
        }
        public static explicit operator int(Sumador s)
        {
            int result;
            result = s.cantidadSumas;
            return result;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
                long result;
                result = s1.cantidadSumas + s2.cantidadSumas;
                return result;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool result = false;
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                result = true;
            }
            return result;
        }
    }
}
