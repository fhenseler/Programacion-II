using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros;
            Stack<int> numerosT;
            Queue<int> numerosQ;
            Random rnd = new Random();
            numeros = new List<int>();
            numerosT = new Stack<int>();
            numerosQ = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                numeros.Add(rnd.Next(-50, 50));
                numerosT.Push(rnd.Next(-50, 50));
                numerosQ.Enqueue(rnd.Next(-50, 50));
            }

            Console.WriteLine("LIST: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("STACK: ");
            foreach (int numero in numerosT)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("QUEUE: ");
            foreach (int numero in numerosQ)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
