using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 4, 5 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", array[i]);
                Console.ReadKey();
            }
        }
    }
}
