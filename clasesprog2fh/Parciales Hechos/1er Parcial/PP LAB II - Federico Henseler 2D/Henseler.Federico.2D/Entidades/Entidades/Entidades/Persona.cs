using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                this.documento = value;
            }
        }

        /// <summary>
        /// Inicializo una nueva Persona, según un nombre, un apellido y un DNI.
        /// </summary>
        /// <param name="nombre">Nombre de la Persona a inicializar.</param>
        /// <param name="apellido">Apellido de la Persona.</param>
        /// <param name="documento">Documento de la Persona.</param>
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        /// <summary>
        /// Genero un string con los datos completos de la Persona.
        /// </summary>
        /// <param name=""></param>
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE: " + this.nombre);
            sb.AppendLine("APELLIDO: " + this.apellido);
            sb.AppendLine("DNI: " + this.documento);
            return sb.ToString();
        }

        public abstract bool ValidarDocumentacion(string doc);

    }
}
