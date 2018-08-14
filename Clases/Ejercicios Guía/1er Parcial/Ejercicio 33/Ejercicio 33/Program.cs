using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Hola";
            Console.WriteLine("{0}", libro[0]);
            Console.ReadKey();
        }
    }
}
