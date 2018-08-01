using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Federico.Henseler._2D;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un grupo y lo inicializo
            Grupo grupo = new Grupo("Río", TipoManada.Única);
            // Creo un Perro y un Gato y los inicializo
            Perro p1 = new Perro("Moro", "Pitbull");
            Gato g1 = new Gato("José", "Angora");

            // Agrego Perro y Gato al Grupo
            grupo = grupo + p1;
            grupo = grupo + g1;

            // Si pertenecen, entonces fueron agregados
            if (grupo == p1)
            {
                Console.WriteLine("Agregó {0}", p1.ToString());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0}!", p1.ToString());
            }

            if (grupo == g1)
            {
                Console.WriteLine("Agregó {0}", g1.ToString());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0}!", g1.ToString());
            }

            grupo = grupo - g1;

            if (grupo != g1)
            {
                Console.WriteLine("Quitó {0}", g1.ToString());
            }
            else
            {
                Console.WriteLine("¡NO quitó {0}!", g1.ToString());
            }

            // Muestro todo el Grupo
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(grupo);

            Console.ReadKey();

        }
    }
}
