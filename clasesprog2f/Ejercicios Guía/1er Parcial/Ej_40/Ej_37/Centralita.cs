using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas=new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia=0;
            for (int i = 0; i < this.listaDeLlamadas.Count(); i++)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.local:
                        if (this.listaDeLlamadas[i] is Local)
                        {
                            ganancia = ganancia + ((Local)this.listaDeLlamadas[i]).CostoLlamada;
                        }

                        break;

                    case Llamada.TipoLlamada.provincial:

                        if (this.listaDeLlamadas[i] is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)this.listaDeLlamadas[i]).CostoLlamada;
                        }
                        
                        break;

                    case Llamada.TipoLlamada.todas:
                        if (this.listaDeLlamadas[i] is Local)
                        {
                            ganancia = ganancia + ((Local)this.listaDeLlamadas[i]).CostoLlamada;
                        }
                        else if (this.listaDeLlamadas[i] is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)this.listaDeLlamadas[i]).CostoLlamada;
                        }
                        break;
                }
            }
            
            return ganancia; 
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("RAZON SOCIAL:"+this.razonSocial);
            sb.AppendLine("GANANCIAS POR LLAMADAS LOCALES: "+this.GananciasPorLocal.ToString());
            sb.AppendLine("GANANCIAS POR LLAMADAS PROVINCIALES: " + this.GananciasPorProvincial.ToString());
            sb.AppendLine("GANANCIA TOTAL DE LLAMADAS: " + this.GananciasPorTotal.ToString());
            /*for (int i = 0; i < this.listaDeLlamadas.Count; i++)
            {
                if (this.listaDeLlamadas[i] is Local)
                {
                    sb.AppendLine("LOCALES: "+this.listaDeLlamadas[i].Mostrar());
                }
                else if (this.listaDeLlamadas[i] is Provincial)
                {
                    sb.AppendLine("PROVINCIALES: "+this.listaDeLlamadas[i].Mostrar());
                }
            }
            */
            return sb.ToString();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);

        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            for (int i = 0; i < c.listaDeLlamadas.Count; i++)
            {
                if (c.listaDeLlamadas[i] == llamada)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            for (int i = 0; i < c.listaDeLlamadas.Count; i++)
            {
                if ( c.listaDeLlamadas[i] != llamada)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Mostrar());
            for (int i = 0; i < this.Llamadas.Count; i++)
            {
                if (this.Llamadas[i] is Local)
                {
                    sb.AppendLine(this.Llamadas[i].ToString());
                }
                else if (this.Llamadas[i] is Provincial)
                {
                    sb.AppendLine(this.Llamadas[i].ToString());
                }
            }

            return sb.ToString();
            
        }
    }
}
