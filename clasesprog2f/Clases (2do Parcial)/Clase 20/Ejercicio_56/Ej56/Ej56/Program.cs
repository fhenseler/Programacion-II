using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej56
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Federico", "Henseler");

            Persona.Guardar(p1);

            Persona p2;
            Persona.Leer("test.xml", out p2);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.ReadKey();

        }
    }
}
