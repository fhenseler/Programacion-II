using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                return this.anio + "º" + division;
            }
        }

        /// <summary>
        /// Inicializo un nuevo Alumno, según un nombre, un apellido y un DNI.
        /// </summary>
        /// <param name="anio">Anio del Alumno a inicializar.</param>
        /// <param name="division">Division del Alumno.</param>
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        /// <summary>
        /// Genero un string con los datos completos del Alumno.
        /// </summary>
        /// <param name=""></param>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.AppendLine("AÑO: " + this.anio.ToString());
            sb.AppendLine("DIVISION: " + this.division.ToString());
            return sb.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            int guionCount = 0;

            for (int i = 0; i < doc.Length; i++)
            {
                if (doc[i].Equals("-"))
                    guionCount++;
            }

            if (doc.Length == 9 && guionCount == 3)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}