using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public enum TipoLlamada { Local, Provincial, Todas }

    public abstract class Llamada
    {
        #region Fields

        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #endregion

        #region Properties

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        #endregion

        #region Methods

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION : " + this._duracion.ToString());
            sb.AppendLine("NRO ORIGEN: " + this._nroOrigen.ToString());
            sb.AppendLine("NRO DESTINO: " + this._nroDestino.ToString());

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1._duracion > llamada2._duracion)
            {
                return 1;
            }
                
            if (llamada1._duracion < llamada2._duracion)
            {
                return -1;
            }
            return 0;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (!object.ReferenceEquals(l1, null) && !object.ReferenceEquals(l2, null))
            {
                if(!(l1 is Local && l2 is Local) || (l1 is Provincial && l2 is Provincial))
                {
                    if ((l1._nroDestino == l2._nroDestino) && (l1._nroOrigen == l2._nroOrigen) && (Equals(l1, l2)))
                    return true;
                }

            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        #endregion
    }
}
