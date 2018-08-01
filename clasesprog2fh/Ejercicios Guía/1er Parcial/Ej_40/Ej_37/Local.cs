using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40
{
    public class Local : Llamada
    {
        protected float _costo;

        #region Local constructores
        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen)
        {
            this._costo=costo;
        }

# endregion
 
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float retorno;
             retorno=this.Duracion * this._costo;
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("COSTO: "+this.CostoLlamada.ToString());

            return sb.ToString();
        }
        //REVISAR
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Local)
            {
                retorno = true;
            }
            
            return retorno;
        }
    }
}
