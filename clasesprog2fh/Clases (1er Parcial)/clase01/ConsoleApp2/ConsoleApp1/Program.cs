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
            double numero;
            string num;

            Console.WriteLine("Ingrese numero mayor a cero: ");
            num = Console.ReadLine();
            numero = double.Parse(num);

            if(numero > 0)
            {
                numero = Math.Pow(numero, 2);
                Console.WriteLine("El cuadrado es: " + numero);
                numero = Math.Pow(numero, 3);
                Console.WriteLine("El cubo es: " + numero);
            }
            else
            {
                Console.WriteLine("Ingrese numero mayor a cero: ");
                num = Console.ReadLine();
                numero = double.Parse(num);
                numero = Math.Pow(numero, 2);
                Console.WriteLine("El cuadrado es: " + numero);
                numero = Math.Pow(numero, 3);
                Console.WriteLine("El cubo es: " + numero);
            }

        }
    }
}