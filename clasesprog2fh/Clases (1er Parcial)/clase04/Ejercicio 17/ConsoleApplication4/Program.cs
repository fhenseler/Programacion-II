using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo();
            Boligrafo rojo = new Boligrafo();

            azul.color = ConsoleColor.Blue;
            rojo.color = ConsoleColor.Red;

            azul.SetTinta(100);
            rojo.SetTinta(50);

            azul.Pintar(30, out "*****");
            Console.ReadKey();
        }
    }
}
