using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Federico.Henseler._2D
{
    public enum TipoManada { Única, Mixta };

    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        public TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }

        static Grupo()
        {
            tipo = TipoManada.Única;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre)
            :this()
        {
            this.nombre = nombre; 
        }

        public Grupo(string nombre, TipoManada tipo)
            :this(nombre)
        {
        }

        /// <summary>
        /// Busca la Mascota pasada por parámetro en la Manada, si la encuentra devuelve True, caso contrario devuelve False.
        /// </summary>
        /// <param name="e">Grupo donde busco la Mascota</param>
        /// <param name="j">Mascota a buscar dentro de la Manada</param>
        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach (Mascota aux in e.manada)
            {
                if (j == aux)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        /// <summary>
        /// Si la Mascota pasada por parámetro no se encuentra en la Manada, la agrega.
        /// </summary>
        /// <param name="e">Grupo al que quiero agregarle la Mascota</param>
        /// <param name="j">Mascota a agregar a la Manada, si es que no se encuentra ya agregada</param>
        public static Grupo operator +(Grupo e, Mascota j)
        {
            foreach (Mascota m in e.manada)
            {
                if (j == m)
                {
                    return e;
                }
            }
            e.manada.Add(j);
            return e;
        }

        /// <summary>
        /// Si la Mascota pasada por parámetro se encuentra en la Manada, la quita.
        /// </summary>
        /// <param name="e">Grupo al que quiero quitarle la Mascota</param>
        /// <param name="j">Mascota a quitar de la Manada</param>
        public static Grupo operator -(Grupo e, Mascota j)
        {
            for (int i = 0; i < e.manada.Count; i++)
            {
                if (!object.ReferenceEquals(e.manada[i], null))
                {
                    if (j == e.manada[i])
                    {
                        e.manada[i] = null;
                        break;
                    }
                }
            }
            return e;
        }

        /// <summary>
        /// Muestra los datos del Grupo
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**" + e.nombre + " " + TipoManada.Única + "**");
            sb.AppendLine("");
            sb.AppendLine("Integrantes: ");
            foreach (Mascota aux in e.manada)
            {
                if(aux != null)
                sb.AppendLine(aux.ToString());
            }
            return sb.ToString();
        }

    }
}
