using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.H._2D
{
    public class DirectorTecnico : Persona
    {
        /// <summary>
        /// Inicializo un nuevo DT, según un nombre y un apellido.
        /// </summary>
        /// <param name="nombre">Nombre del DT a inicializar.</param>
        /// <param name="raza">Apellido del DT</param>
        public DirectorTecnico(string nombre, string apellido)
            : base(nombre, apellido)
        {
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        protected override string FichaTecnica()
        {
            string retorno = String.Format("{0}", this.NombreCompleto());
            return retorno;
        }

    }
}
