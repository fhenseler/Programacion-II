using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.H._2D
{
    public class Equipo
    {
            public enum Deportes { Fútbol, Handball, Básquet, Rugby };

            private List<Jugador> jugadores;
            private string nombre;
            private static Deportes deporte;
            private DirectorTecnico dt;

            public Deportes Deporte
            {
                set
                {
                    deporte = value;
                }
            }

            static Equipo()
            {
                deporte = Deportes.Fútbol;
            }

            private Equipo()
            {
                this.jugadores = new List<Jugador>();
            }

            public Equipo(string nombre)
                : this()
            {
                this.nombre = nombre;
            }

            public Equipo(string nombre, Deportes deporte)
                : this(nombre)
            {
            }


            /// <summary>
            /// Busca el Jugador pasado por parámetro en el Equipo, si lo encuentra devuelve True, caso contrario devuelve False.
            /// </summary>
            /// <param name="e">Equipo donde busco al Jugador</param>
            /// <param name="j">Jugador a buscar dentro del Equipo</param>
            public static bool operator ==(Equipo e, Jugador j)
            {
                foreach (Jugador aux in e.jugadores)
                {
                    if (j == aux)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static bool operator !=(Equipo e, Jugador j)
            {
                return !(e == j);
            }

            /// <summary>
            /// Si el Jugador pasado por parámetro no se encuentra en el equipo, lo agrega.
            /// </summary>
            /// <param name="e">Equipo al que quiero agregarle el Jugador</param>
            /// <param name="j">Jugador a agregar al Equipo, si es que no se encuentra ya agregado</param>
            public static Equipo operator +(Equipo e, Jugador j)
            {
                foreach (Jugador m in e.jugadores)
                {
                    if (j == m)
                    {
                        return e;
                    }
                }
                e.jugadores.Add(j);
                return e;
            }

            public static Equipo operator -(Equipo e, Jugador j)
            {
                for (int i = 0; i < e.jugadores.Count; i++)
                {
                    if (!object.ReferenceEquals(e.jugadores[i], null))
                    {
                        if (j == e.jugadores[i])
                        {
                            e.jugadores[i] = null;
                            break;
                        }
                    }
                }
                return e;
            }

            /// <summary>
            /// Muestra los datos del Equipo
            /// </summary>
            /// <param name="e"></param>
            /// <returns></returns>
            public static implicit operator string(Equipo e)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(e.nombre + "" + deporte);
                sb.AppendLine("Integrantes: ");
                foreach (Jugador aux in e.jugadores)
                {
                    if (aux != null)
                        sb.AppendLine(aux.ToString());
                }
                return sb.ToString();
            }

        }
}
