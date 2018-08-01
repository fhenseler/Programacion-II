using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public DateTime Antiguedad
        {
            get
            {
                //ARREGLAR
                return this.fechaIngreso;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("FECHA INGRESO: " + this.fechaIngreso.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Inicializo un nuevo Profesor, según un nombre, un apellido, un DNI y una Fecha de ingreso.
        /// </summary>
        /// <param name="documento">DNI del profesor a inicializar.</param>
        /// <param name="fechaIngreso">Fecha de ingreso del Profesor.</param>
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        /// <summary>
        /// Inicializo un nuevo Profesor, según un nombre, un apellido y un DNI.
        /// </summary>
        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {
        }

        public override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;

            if (doc.Length == 8)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}