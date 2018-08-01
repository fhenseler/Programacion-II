using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.H._2D
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        /// <summary>
        /// Inicializo un nuevo Jugador, según un nombre y un apellido.
        /// </summary>
        /// <param name="nombre">Nombre del Jugador a inicializar.</param>
        /// <param name="apellido">Apellido del Jugador.</param>  
        public Jugador(string nombre, string apellido)
            : base(nombre, apellido)
        {
            this.numero = 0;
            this.esCapitan = false;
        }

        /// <summary>
        /// Inicializo un nuevo Jugador, asignando todos sus atributos
        /// </summary>
        /// <param name="numero">Numero del jugador</param>
        /// <param name="esCapitan">Indica si es el capitán del equipo</param>
        public Jugador(string nombre, string apellido, int numero, bool esCapitan)
            : this(nombre, apellido)
        {
            this.numero = numero;
            this.esCapitan = esCapitan;
        }

        public override bool Equals(object obj)
        {
            Jugador aux = (Jugador)obj;
            if (!object.ReferenceEquals(obj, null))
            {
                if ((Nombre == aux.Nombre && Apellido == aux.Apellido && Numero == aux.numero))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Compara dos objetos del tipo Jugador, si el nombre, el apellido y el número son iguales devuelve True, caso contrario devuelve False.
        /// </summary>
        /// <param name="obj1">Objeto a comparar</param>
        /// <param name="obj2">Objeto a comparar</param>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (!object.ReferenceEquals(j1, null) && !object.ReferenceEquals(j2, null))
            {
                if ((j1.Nombre == j2.Nombre) && (j1.Apellido == j2.Apellido) && (j1.Numero == j2.Numero))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Jugador jugador)
        {
            int numero = jugador.numero;
            return numero;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        protected override string FichaTecnica()
        {
            string retorno;

            if (this.esCapitan)
            {
                retorno = String.Format("{0}, Capitán del equipo, Camiseta número {1}", this.NombreCompleto(), this.Numero);
            }
            else
            {
                retorno = String.Format("{0}, Camiseta número {1}", this.NombreCompleto(), this.Numero);
            }

            return retorno;
        }
    }
}
