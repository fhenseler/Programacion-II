using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public enum TipoLlamada { Local, Provincial, Todas }

    public class Llamada
    {
        #region Fields

        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #endregion

        #region Properties

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

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION : " + Duracion);
            sb.AppendLine("NRO ORIGEN: " + NroOrigen);
            sb.AppendLine("NRO DESTINO: " + NroDestino);

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

        #endregion
    }
}
