using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Centralita : IGuardar<String>
    {
        #region Fields
        private List<Llamada> _listaDeLlamadas;
        private string _razonSocial;
        public DateTime localDate = DateTime.Now;
        private string rutaDeArchivo = "centralita.log";
        #endregion

        #region Properties

        public string RutaDeArchivo
        {
            get;
            set;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }
        #endregion

        #region Methods
        public bool Guardar()
        {
            StreamWriter writer = new StreamWriter(this.rutaDeArchivo, true);

            writer.WriteLine("");
            writer.WriteLine(this.localDate + "- Se realizó una llamada");
            writer.Flush();
            writer.Close();
            return true;
        }

        public bool Leer()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Recibe un Enumerado de tipo TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido.
        /// </summary>
        /// <param name="tipo">Criterio para la suma de las ganancias.</param>
        /// <returns></returns>
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float total = 0;
            // Recorro la lista de llamadas.
            foreach (Llamada l in this._listaDeLlamadas)
            {
                // Según el tipo de llamada que quiero analizar, opero.
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        // Si el TipoLlamada es Local y la clase es del tipo Local...
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        break;
                    case TipoLlamada.Provincial:
                        // Si el TipoLlamada es Provincial y la clase es del tipo Provincial...
                        if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                    case TipoLlamada.Todas:
                        // Si el TipoLlamada es Todas y verifico el tipo de la llamada para castear.
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        else if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                }
            }

            return total;
        }

        /// <summary>
        /// Genera y retorna una cadena de texto con la información de la central.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CENTRAL  : " + this._razonSocial);
            sb.AppendLine("*******************************************");

            sb.AppendLine("GANANCIAS");
            sb.AppendLine("TOTALES      : " + this.GananciasPorTotal);
            sb.AppendLine("LOCALES      : " + this.GananciasPorLocal);
            sb.AppendLine("PROVINCIALES : " + this.GananciasPorProvincial);

            sb.AppendLine("*******************************************");
            sb.AppendLine("DETALLE DE LLAMADAS");
            foreach (Llamada l in this._listaDeLlamadas)
            {
                if (l is Local)
                    sb.AppendLine(((Local)l).Mostrar());
                else if (l is Provincial)
                    sb.AppendLine(((Provincial)l).Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            :this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            foreach (Llamada m in c._listaDeLlamadas)
            {
                try
                {
                    if (nuevaLlamada == m)
                    {
                        return c;
                    }
                }
                catch(CentralitaException x)
                {
                    //throw new CentralitaException(x.Message, x.nombreClase, x.nombreMetodo, x.InnerException);
                    throw x;
                }
            }
            c.AgregarLlamada(nuevaLlamada);
            c.Guardar();
            return c;
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada aux in c._listaDeLlamadas)
            {
                if (llamada == aux)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        #endregion
    }
}
