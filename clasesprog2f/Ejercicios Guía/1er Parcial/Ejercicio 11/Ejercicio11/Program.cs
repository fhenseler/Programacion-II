using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                if (Validacion.Validar(numero, -100, 100))
                {
                    Console.WriteLine("{0}", numero);
                }
                else
                {
                    Console.Write("Valor fuera de rango");
                    Console.Write("");
                }
            }
        }
    }
}
