using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool value;

            if (c.competidores.Contains(a))
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            // Si el Estante no contiene el Producto...
            if (c != a)
            {
                // Recorro la lista de productos del estante...
                for (int i = 0; i < c.competidores.Count; i++)
                {
                    // Busco un espacio vacio
                    if (object.ReferenceEquals(c.competidores[i], null))
                    {
                        c.competidores[i] = a;
                        // Si agregué, rompo el lazo para no volver a agregarlo.
                        return true;
                    }
                }
            }
            // Si no salió hasta acá es porque no agregó el ítem
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool value = false;
            // Recorro la lista de productos del estante...
            for (int i = 0; i < c.competidores.Count; i++)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(c.competidores[i], null))
                {
                    // Utilizo la sobrecarga del == de Producto
                    if (a == c.competidores[i])
                    {
                        // Vacio el espacio que ocupaba dicho Producto
                        c.competidores = null;
                        value = true;
                        // Rompo el lazo
                        break;
                    }
                }
            }
            return value;
        }


        //private short cantidadCompetidores;
        //private short cantidadVueltas;
        //private List<AutoF1> competidores;
        public static string MostrarDatos(Competencia c)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("======================COMPETENCIA======================");
            sb.AppendLine("CANT COMPETIDORES: " + c.cantidadCompetidores);
            sb.AppendLine("CANT VUELTAS: " + c.cantidadVueltas);
            sb.AppendLine("COMPETIDORES:");
            foreach (AutoF1 a in c.competidores)
            {
                sb.AppendLine(AutoF1.MostrarDatos(a));
            }

            return sb.ToString();
        }
    }
}
