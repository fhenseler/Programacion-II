using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Federico.Henseler._2D
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }

        /// <summary>
        /// Inicializo un nuevo Perro, según un nombre y una raza.
        /// </summary>
        /// <param name="nombre">Nombre del perro a inicializar.</param>
        /// <param name="raza">Raza del perro.</param>       
        public Perro(string nombre, string raza)
            : base(nombre, raza)
        {
        }


        /// <summary>
        /// Inicializo un nuevo Perro, asignando todos sus atributos
        /// </summary>
        /// <param name="edad">Edad del perro</param>
        /// <param name="esAlfa">Indica si es el alfa de la manada</param>
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : this(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            string retorno;

            if (this.esAlfa)
            {
                retorno = String.Format("{0}, Alfa de la manada, Edad {1}", this.DatosCompletos(), this.edad);
            }
            else
            {
                retorno = String.Format("{0}, Edad {1}", this.DatosCompletos(), this.Edad);
            }

            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            Perro aux = (Perro)obj;
            if (!object.ReferenceEquals(obj, null))
            {
                if ((Nombre == aux.Nombre && Raza == aux.Raza && Edad == aux.Edad))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Compara dos objetos del tipo Perro, si el nombre. la raza y la edad son iguales devuelve True, caso contrario devuelve False.
        /// </summary>
        /// <param name="obj1">Objeto a comparar</param>
        /// <param name="obj2">Objeto a comparar</param>
        public static bool operator ==(Perro j1, Perro j2)
        {
            if (!object.ReferenceEquals(j1, null) && !object.ReferenceEquals(j2, null))
            {
                if ((j1.Nombre == j2.Nombre) && (j1.Raza == j2.Raza) && (j1.Edad == j2.Edad))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro perro)
        {
            int edad = perro.edad;
            return edad;
        }
    }
}
