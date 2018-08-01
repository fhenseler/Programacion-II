using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int[] arrayPos = new int[20];
            int[] arrayNeg = new int[20];

            Random rnd = new Random();
            Console.Write("ARRAY ORIGINAL: ");
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(-50, 50);
                Console.WriteLine("{0} ", array[i]);

                if (array[i] > 0)
                {
                    arrayPos[i] = array[i];
                }
                if (array[i] < 0)
                {
                    arrayNeg[i] = array[i];
                } 
            }
            Console.Write("POSITIVOS: ");
            Array.Sort(arrayPos);
            Array.Reverse(arrayPos);
            for (int i = 0; i < arrayPos.Length; i++)
            {
                if(arrayPos[i] != 0)
                Console.WriteLine("{0} ", arrayPos[i]);
            }
            Console.Write("NEGATIVOS: ");
            Array.Sort(arrayNeg);
            for (int i = 0; i < arrayNeg.Length; i++)
            {
                if (arrayNeg[i] != 0)
                Console.WriteLine("{0} ", arrayNeg[i]);
            }

            Console.ReadKey();
        }
    }
}
