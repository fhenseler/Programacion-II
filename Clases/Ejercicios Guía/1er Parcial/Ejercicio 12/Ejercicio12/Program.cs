using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum = 0;
            char resp;

            do
            {
                Console.WriteLine("Acum: {0}", acum);
                Console.WriteLine("Continuar? (S/N): ");
                resp = Console.ReadKey().KeyChar;
                acum++;
            } while (resp == 'S');

                Console.WriteLine("Cant de 'S': {0}", acum);
                Console.ReadKey();
        }
    }
}
