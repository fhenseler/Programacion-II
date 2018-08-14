using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Boligrafo
    {
        private const int cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;

        // Method
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public int GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta <= cantidadTintaMaxima && tinta > 0)
            {
                this.tinta = tinta;
            }
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            this.tinta = this.tinta - gasto;

            if (this.tinta > 0)
            {
                Console.WriteLine("Se pudo pintar!");
                dibujo = "";
                Console.WriteLine("{0}", dibujo);
                retorno = true;
            }

            return retorno;

        }
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }
    }
}
