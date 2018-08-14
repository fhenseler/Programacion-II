using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(6, "Ferrari");
            AutoF1 a2 = new AutoF1(2, "BMW");
            AutoF1 a3 = new AutoF1(11, "Mercedes Benz");

            Competencia competencia = new Competencia(10, 3);

            a1.SetCantCombustible(9);

            if (competencia + a1)
            {
                Console.WriteLine("Agregó {0}", a1.GetCantCombustible());
            }
            else
            {
                Console.WriteLine("¡NO agregó!");
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Competencia.MostrarDatos(competencia));

            Console.ReadKey();
        }
    }
}
