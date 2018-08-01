using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion, miFranja)
        {

        }

        public Provincial(string origen, string destino, float duracion, Franja miFranja): base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }

        private float CalcularCosto()
        {
            float costo=0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo=(this.Duracion * (float)this._franjaHoraria) / 100;
                    break;

                case Franja.Franja_2:
                    costo = (this.Duracion * (float)this._franjaHoraria) / 100;
                    break;

                case Franja.Franja_3:
                    costo = (this.Duracion * (float)this._franjaHoraria) / 100;
                    break;
            }

            return costo;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("FRANJA HORARIA: " + this._franjaHoraria.ToString());
            sb.AppendLine("COSTO DE LLAMADA: "+this.CostoLlamada.ToString());

            return sb.ToString();
        }

        public override bool Equals(object llamada)
        {
            bool retorno = false;
            if (llamada is Provincial)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            
            return this.Mostrar();
        }


    }
}
