using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Provincial : Llamada, IGuardar<String>
    {
        public enum Franja { Franja_1 = 99, Franja_2 = 125, Franja_3 = 66 }

        #region Fields
        private Franja _franjaHoraria;
        private string rutaDeArchivo = "test.txt";
        public string textoLeido;
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

        /// <summary>
        /// Genera y retorna una cadena de texto con la información de la llamada.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LLAMADA PROVINCIAL");
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo    : " + this.CostoLlamada);
            sb.AppendLine("Franja   : " + this._franjaHoraria.ToString());

            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return (((float)this._franjaHoraria) / 100) * base.Duracion;
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
            StreamWriter writer = new StreamWriter(this.rutaDeArchivo, false);

            writer.Write("");
            writer.Write(this.Mostrar());
            writer.Flush();
            writer.Close();
            return true;
        }

        public bool Leer()
        {
            StreamReader reader = new StreamReader(this.rutaDeArchivo, false);

            this.textoLeido = reader.ReadToEnd();
            reader.Close();
            return true;
        }
    }
}
