using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz
    {
        private float tamanioMina;

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
                return 0.1F;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper retorno = new EscrituraWrapper(texto, this.Color);
            for (int i = 0; i < texto.Length; i++)
            {
                this.tamanioMina -= (float)0.3;
            }
            //retorno = this.tamanioMina;

            return retorno;
        }

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this is Lapiz)
                sb.AppendLine("Lapiz");
            else
                sb.AppendLine("Boligrafo");
            sb.AppendLine("COLOR: " + this.Color);
            sb.AppendLine("TAMANIO DE MINA: " + this.tamanioMina);

            return sb.ToString();
        }

    }
}
