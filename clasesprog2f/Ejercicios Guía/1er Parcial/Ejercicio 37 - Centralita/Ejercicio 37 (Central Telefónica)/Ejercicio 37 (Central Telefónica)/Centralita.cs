﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public class Centralita
    {
        #region Fields
        private List<Llamada> _listaDeLlamadas;
        private string _razonSocial;
        #endregion

        #region Properties
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
                    ((Local)llamadaAux).Mostrar();
                }
                if (llamadaAux is Provincial)
                {
                    ((Provincial)llamadaAux).Mostrar();
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

        #endregion
    }
}
