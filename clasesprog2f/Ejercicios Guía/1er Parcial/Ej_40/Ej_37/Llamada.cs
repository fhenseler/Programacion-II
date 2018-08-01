using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40
{
    
    abstract public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
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

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DURACION DE LA LLAMADA: " + this._duracion.ToString());
            sb.AppendLine("NRO DESTINO: " + this._nroDestino);
            sb.AppendLine("NRO ORIGEN: " + this._nroOrigen);
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno=0;
            if (llamada1._duracion < llamada2._duracion)
            {
                retorno = 1;
            }
            else if (llamada2._duracion < llamada1._duracion)
            {
                retorno = -1;
            }
            return retorno;
        }

        public enum TipoLlamada
        {
            local,
            provincial,
            todas
        }

        abstract public float CostoLlamada
        {
            get;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if ((l1.NroDestino == l2.NroDestino) && (l1.NroOrigen == l2.NroOrigen) && (l1.Equals(l2)))
            {
                retorno = false;
            }
            else
            {
                retorno=true;
            }
            return retorno;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if ((l1.NroDestino == l2.NroDestino) && (l1.NroOrigen == l2.NroOrigen) && (l1.Equals(l2)))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
