using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return 0.3F;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper retorno = new EscrituraWrapper(texto, this.colorTinta);
            for (int i = 0; i < texto.Length; i++)
            {
                this.tinta -= (float)0.3;
            }
            //retorno = this.tinta;

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this is Boligrafo)
                sb.AppendLine("Boligrafo");
            else
                sb.AppendLine("Lapiz");
            sb.AppendLine("COLOR: " + this.colorTinta);
            sb.AppendLine("NIVEL DE TINTA" + this.tinta);

            return sb.ToString();
        }
    }
}
