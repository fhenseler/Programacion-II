using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Boligrafo
    {
        public const int cantidadTintaMaxima = 100;
        public int tinta;
        public ConsoleColor color;

        // Method
        public ConsoleColor GetColor()
        {
            return color;
        }
        public int GetTinta()
        {
            return tinta;
        }
        public bool Pintar(int gasto, out string dibujo)
        {
            tinta = tinta - gasto;

            if (tinta > 0)
            {
                Console.WriteLine("Se pudo pintar!");
                Console.WriteLine("{0}", dibujo);
            }

        }
        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }
        private void SetTinta(int cantTinta)
        {
            if (cantTinta <= cantidadTintaMaxima && cantTinta > 0)
            {
                tinta = cantTinta;
            }
        }
    }
}
