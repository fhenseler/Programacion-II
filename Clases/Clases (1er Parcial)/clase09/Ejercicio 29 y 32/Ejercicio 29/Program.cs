using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j = new Jugador(30333000, "Fede", 25, 12);
            Equipo e = new Equipo(11, "Hola FC");

            bool resultado = false;

            resultado = e + j;

            if (resultado == true)
            {
                Console.WriteLine("JUGADOR {0} AGREGADO AL EQUIPO", j.mostrarDatos());
            }
            else
            {
                Console.WriteLine("El jugador no se pudo agregar");
            }
            Console.ReadKey();
        }
    }
}
