using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = { 1, 2, 3 };
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                string numero = Console.ReadLine();
                numeros[i] = int.Parse(numero);
            }
                Console.WriteLine("El maximo es: " + numeros.Max());
                Console.WriteLine("El minimo es: " + numeros.Min());
                Console.WriteLine("El promedio es: " + numeros.Average());
                Console.Write("{0} {1} {2} {3} {4}", numeros[0], numeros[1], numeros[2], numeros[3], numeros[4]);
                Console.ReadKey();
        }
    }
}
