using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F.H._2D;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           // Creo un Jugador y un DT y los inicializo
           Jugador p1 = new Jugador("Fernando", "Pandolfi", 11, true);
           DirectorTecnico g1 = new DirectorTecnico("Federico", "Angora");
            
           // Creo un Equipo y lo inicializo
           Equipo equipo = new Equipo("Huracán de San Rafael", Equipo.Deportes.Fútbol);

           //Agrego Jugador al Equipo
           equipo = equipo + p1;

           // Si pertenece, entonces fue agregado
            if (equipo == p1)
            {
                Console.WriteLine("Agregó {0}", p1.ToString());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0}!", p1.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");

            // Muestro todo el Equipo
            Console.WriteLine(equipo);
            Console.WriteLine(g1);

            Console.ReadKey();
        }
    }
}
