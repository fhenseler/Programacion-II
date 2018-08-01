using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio67
{
    public sealed class Temporizador
    {
        private Thread hilo = new Thread(Corriendo);
        private int intervalo;

        public bool Activo
        {
            get
            {
                return this.Activo;
            }
            set
            {
                if (Activo)
                    hilo.Start(1);
                else
                    hilo.Abort();
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        public void Corriendo()
        {
            Thread.Sleep(intervalo);
            EventoTiempo("Evento tiempo lanzado");
        }

        public event encargadoTiempo EventoTiempo;
        public delegate void encargadoTiempo(string message);
    }
}
