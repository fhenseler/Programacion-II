using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short GetCantCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetCantCombustible(short cantCombustible)
        {
            this.cantidadCombustible = cantCombustible;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool value;

            if (a1.escuderia == a2.escuderia && a1.numero == a2.numero)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            bool value;

            if (a1.escuderia != a2.escuderia || a1.numero != a2.numero)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }


        //private short cantidadCombustible;
        //private bool enCompetencia;
        //private string escuderia;
        //private short numero;
        //private short vueltasRestantes;
        public static string MostrarDatos(AutoF1 a)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("======================AUTO======================");
            sb.AppendLine("CANT COMBUSTIBLE: " + a.cantidadCombustible);
            sb.AppendLine("EN COMPETENCIA: " + a.enCompetencia);
            sb.AppendLine("ESCUDERIA: " + a.escuderia);
            sb.AppendLine("NUMERO: " + a.numero);
            sb.AppendLine("ESCUDERIA: " + a.vueltasRestantes);

            return sb.ToString();
        }


    }
}
