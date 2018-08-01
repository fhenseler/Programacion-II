using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1 = 99, Franja_2 = 125, Franja_3 = 66 }

        #region Fields
        private Franja _franjaHoraria;
        #endregion

        #region Properties
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Methods

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            //base.Mostrar();
            sb.AppendLine("DURACION : " + Duracion);
            sb.AppendLine("NRO ORIGEN: " + NroOrigen);
            sb.AppendLine("NRO DESTINO: " + NroDestino);
            sb.AppendLine("COSTO LLAMADA: " + CostoLlamada);
            sb.AppendLine("FRANJA HORARIA: " + _franjaHoraria);

            return sb.ToString();
        }
        private float CalcularCosto()
        {
            float valorLlamada = 0;
            if(this._franjaHoraria == Franja.Franja_1)
            {
                valorLlamada = this._duracion * (int)this._franjaHoraria / 100;
            }
            if (this._franjaHoraria == Franja.Franja_2)
            {
                valorLlamada = this._duracion * (int)this._franjaHoraria / 100;
            }
            if (this._franjaHoraria == Franja.Franja_3)
            {
                valorLlamada = this._duracion * (int)this._franjaHoraria / 100;
            }
            return valorLlamada;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            //:this(miFranja, new Llamada(duracion, destino, origen))
        {
        }

        public override bool Equals(object obj)
        {
            Provincial aux = (Provincial)obj;
            if (!object.ReferenceEquals(obj, null))
            {
                if (aux is Provincial)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
