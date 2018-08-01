using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Local : Llamada
    {
        #region Fields
        private float _costo;
        #endregion

        #region Properties
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Methods
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            //base.Mostrar();

            sb.AppendLine("DURACION : " + Duracion);
            sb.AppendLine("NRO ORIGEN: " + NroOrigen);
            sb.AppendLine("NRO DESTINO: " + NroDestino);
            sb.AppendLine("COSTO LLAMADA: " + CostoLlamada);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float valorLlamada;
            valorLlamada = this._duracion * this._costo;
            return valorLlamada;
        }

        public Local(Llamada llamada, float costo)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            :this(new Llamada(duracion, destino, origen), costo)
        {
        }

        #endregion
    }
}
