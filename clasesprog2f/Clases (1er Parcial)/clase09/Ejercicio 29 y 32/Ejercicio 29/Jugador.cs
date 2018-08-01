using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private long dni;
        private string nombre;
        private readonly int partidosJugados;
        //private readonly float promedioGoles;
        private readonly int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
            this.nombre = "";
        }

        public Jugador(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Jugador(long dni, string nombre, int totalGoles, int totalPartidos)
            :this(nombre)
        {
            this.dni = dni;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float PromedioGoles
        {
            get
            {
                return this.totalGoles / this.partidosJugados;
            }
        }
        //public float GetPromedioGoles()
        //{
        //    this.promedioGoles = this.totalGoles / this.partidosJugados;
        //    return this.promedioGoles;
        //}

        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DNI: {0}", this.dni);
            sb.AppendLine("");

            sb.AppendFormat("NOMBRE: {0}", this.nombre);
            sb.AppendLine("");

            sb.AppendFormat("PARTIDOS JUGADOS: {0}", this.partidosJugados);
            sb.AppendLine("");

            sb.AppendFormat("TOTAL GOLES: {0}", this.totalGoles);
            sb.AppendLine("");

            sb.AppendFormat("PROMEDIO GOLES: {0}", this.PromedioGoles);
            sb.AppendLine("");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
