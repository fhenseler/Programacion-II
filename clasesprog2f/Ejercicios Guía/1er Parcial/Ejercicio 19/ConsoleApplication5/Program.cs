using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 18, num2 = 3;
            string nom1 = "Federico", nom2 = "Henseler";

            Sumador calculo = new Sumador();
            Sumador calculo2 = new Sumador();

            Console.WriteLine(calculo.Sumar(num1, num2));
            Console.WriteLine(calculo.Sumar(nom1, nom2));

            Console.WriteLine(calculo + calculo2);
            Console.WriteLine(calculo | calculo2);

            Console.ReadKey();

        }
    }
}
