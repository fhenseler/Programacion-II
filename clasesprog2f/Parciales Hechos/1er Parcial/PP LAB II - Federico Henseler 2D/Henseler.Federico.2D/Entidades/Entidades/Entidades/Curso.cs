using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                return this.anio + "º" + division;
            }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();
            this.profesor = new Profesor("Fede", "Dávila", "12345678", new DateTime(2015, 03, 20));
        }

        /// <summary>
        /// Inicializo un nuevo Curso, según un año, una division y un profesor.
        /// </summary>
        public Curso(short anio, Divisiones division, Profesor profesor)
            :this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            foreach (Alumno aux in c.alumnos)
            {
                if (aux.AnioDivision == c.AnioDivision)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        /// <summary>
        /// Muestra los datos del Curso
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**" + c.anio + " " + c.division + "**");
            sb.AppendLine("");
            //sb.AppendLine(profesor.ExponerDatos());
            sb.AppendLine("Integrantes: ");
            foreach (Alumno aux in c.alumnos)
            {
                if (aux != null)
                   sb.AppendLine(aux.ExponerDatos());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Si el Alumno pasado por parámetro no se encuentra en el Curso, lo agrega
        /// </summary>
        /// <param name="c">Curso al que quiero agregar el Alumno</param>
        /// <param name="a">Alumno a agregar al Curso, si es que no se encuentra ya agregado</param>
        public static Curso operator +(Curso c, Alumno a)
        {
            foreach (Alumno m in c.alumnos)
            {
                if (a == m)
                {
                    return c;
                }
            }
            c.alumnos.Add(a);
            return c;
        }
    }
}
