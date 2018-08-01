using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Federico.Henseler._2D
{
    public class Gato : Mascota
    {
        /// <summary>
        /// Inicializo un nuevo gato, según un nombre y una raza.
        /// </summary>
        /// <param name="nombre">Nombre del gato a inicializar.</param>
        /// <param name="raza">Raza del gato.</param>
        public Gato(string nombre, string raza)
            :base(nombre, raza)
        {
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            Gato aux = (Gato)obj;
            if (!object.ReferenceEquals(obj, null))
            {
                if ((Nombre == aux.Nombre && Raza == aux.Raza))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Compara dos objetos del tipo Gato, si el nombre y la raza iguales devuelve True, caso contrario devuelve False.
        /// </summary>
        /// <param name="obj1">Objeto a comparar</param>
        /// <param name="obj2">Objeto a comparar</param>
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            if (!object.ReferenceEquals(obj1, null) && !object.ReferenceEquals(obj2, null))
            {
                if ((obj1.Nombre == obj2.Nombre) && (obj1.Raza == obj2.Raza))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }

        protected override string Ficha()
        {
            string retorno = String.Format("{0}", this.DatosCompletos());
            return retorno;
        }

    }
}
