using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the constructor that has no parameters.
            Alumno alumno1 = new Alumno();
            alumno1.SetName("Federico");
            alumno1.Estudiar(9, 10);
            alumno1.CalcularFinal();
            alumno1.Mostrar();

            Alumno alumno2 = new Alumno();
            alumno2.SetName("Julian");
            alumno2.Estudiar(10, 7);
            alumno2.CalcularFinal();
            alumno2.Mostrar();
 
            Alumno alumno3 = new Alumno();
            alumno3.SetName("Joaquin");
            alumno3.Estudiar(3, 2);
            alumno3.CalcularFinal();
            alumno3.Mostrar();

            Console.ReadKey();
            
        }
    }
}
