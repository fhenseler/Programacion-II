using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Centralita : IGuardar<String>
    {
        #region Fields
        private List<Llamada> _listaDeLlamadas;
        private string _razonSocial;
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
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
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
            throw new NotImplementedException();
        }

        public bool Leer()
        {
            throw new NotImplementedException();
        }


        private float CalcularGanancia(TipoLlamada tipo)
        {
            float acumulador = 0;
            Llamada llamadaAux;

            for(int i = 0; i < this._listaDeLlamadas.Count; i++)
            {
                llamadaAux =  this._listaDeLlamadas[i];
                if (llamadaAux is Local && (tipo == TipoLlamada.Local || tipo == TipoLlamada.Todas))
                {
                    acumulador += ((Local)llamadaAux).CostoLlamada;
                }
                else if (_listaDeLlamadas[i] is Provincial && (tipo == TipoLlamada.Provincial || tipo == TipoLlamada.Todas))
                {
                    acumulador += ((Provincial)llamadaAux).CostoLlamada;
                }
            }
            return acumulador;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            Llamada llamadaAux;

            sb.AppendLine("RAZON SOCIAL: " + this._razonSocial);
            sb.AppendLine("GANANCIA TOTAL: " + GananciasPorTotal);
            sb.AppendLine("GANANCIA LOCAL: " + GananciasPorLocal);
            sb.AppendLine("GANANCIA PROVINCIAL: " + GananciasPorProvincial);

            sb.AppendLine("DETALLE LLAMADA: ");

            for (int i = 0; i < this._listaDeLlamadas.Count; i++)
            {
                llamadaAux = this._listaDeLlamadas[i];
                if (llamadaAux is Local)
                {
                    sb.AppendLine(((Local)llamadaAux).ToString());
                }
                if (llamadaAux is Provincial)
                {
                    sb.AppendLine(((Provincial)llamadaAux).ToString());
                }
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            _listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
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
