using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Local : Llamada, IGuardar<String>
    {
        #region Fields
        private float _costo;
        private string rutaDeArchivo = "test.txt";
        public string textoLeido;
        #endregion

        #region Properties
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
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

            sb.AppendLine("LLAMADA LOCAL");
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo    : " + this.CostoLlamada);

            return sb.ToString();
        }

        /// <summary>
        /// Retornará el valor de la llamada a partir de la duración y el costo de la misma
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            return this._costo * base.Duracion;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }

        public override bool Equals(object obj)
        {
            Local aux = (Local)obj;
            if (!object.ReferenceEquals(obj, null))
            {
                if (aux is Local)
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
