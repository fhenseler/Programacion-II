using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.H._2D
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;

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


        /// <summary>
        /// Inicializo una nueva Persona, según un nombre y un apellido.
        /// </summary>
        /// <param name="nombre">Nombre de la Persona a inicializar.</param>
        /// <param name="raza">Apellido de la Persona.</param>
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Genero un string con los datos completos de la Persona.
        /// </summary>
        /// <param name=""></param>
        virtual protected string NombreCompleto()
        {
            string nombreCompleto = String.Format("{0} {1}",  this.nombre, this.apellido);
            return nombreCompleto;
        }

        virtual protected string FichaTecnica()
        {
            return "";
        }
    }
}
