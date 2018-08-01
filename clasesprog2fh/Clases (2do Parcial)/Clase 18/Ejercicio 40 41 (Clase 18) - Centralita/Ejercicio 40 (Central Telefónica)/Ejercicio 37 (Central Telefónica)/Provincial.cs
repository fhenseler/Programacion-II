using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Provincial : Llamada, IGuardar<String>
    {
        public enum Franja { Franja_1 = 99, Franja_2 = 125, Franja_3 = 66 }

        #region Fields
        private Franja _franjaHoraria;
        #endregion

        #region Properties
        public string RutaDeArchivo
        {
            get;
            set;
        }

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

            sb.Append(base.Mostrar());
            //sb.AppendLine("DURACION : " + this._duracion.ToString());
            //sb.AppendLine("NRO ORIGEN: " + this._nroOrigen.ToString());
            //sb.AppendLine("NRO DESTINO: " + this._nroDestino.ToString());
            sb.AppendLine("FRANJA HORARIA: " + this._franjaHoraria.ToString());

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
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
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

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public bool Leer()
        {
            throw new NotImplementedException();
        }
    }
}
