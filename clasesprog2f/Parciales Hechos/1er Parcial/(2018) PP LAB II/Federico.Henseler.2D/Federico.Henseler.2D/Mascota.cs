using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Federico.Henseler._2D
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        /// <summary>
        /// Inicializo una nueva mascota, según un nombre y una raza.
        /// </summary>
        /// <param name="nombre">Nombre de la mascota a inicializar.</param>
        /// <param name="raza">Raza de la mascota.</param>
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        protected virtual string Ficha()
        {
            return "";
        }

        /// <summary>
        /// Genero un string con los datos completos de la mascota.
        /// </summary>
        /// <param name=""></param>
        protected virtual string DatosCompletos()
        {
            string retorno = String.Format("{0} {1}", this.nombre, this.raza);
            return retorno;
        }
    }
}
