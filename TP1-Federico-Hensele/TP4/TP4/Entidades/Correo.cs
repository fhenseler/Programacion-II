using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    // Implementa la interfaz
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Fields

        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        #endregion

        #region Properties

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #endregion

        #region Methods

        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        /// <summary>
        /// Cierra todos los hilos activos
        /// </summary>
        public void FinEntregas()
        {
            Environment.Exit(Environment.ExitCode);
        }

        /// <summary>
        /// Expone los datos del elemento y su lista
        /// </summary>
        /// <param name="elementos">Elementos a exponer</param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Paquete p in this.paquetes)
            {
                sb.AppendFormat("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
                sb.AppendLine("");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Agrega un elemento a la lista, controlando que no forme parte de ésta previamente,
        /// además crea un hilo para MockCicloDeVida y lo agrega a la lista MockPaquetes. Finalmente ejecuta el hilo
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete v in c.Paquetes)
            {
                if (v == p)
                    throw new TrackingIdRepetidoException("El Tracking ID" + " " + p.TrackingID + " " + "ya figura en la lista de envíos.");
                    break;
            }
            c.Paquetes.Add(p);
            Thread miThread = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(miThread);
            miThread.Start();
            return c;
        }

        #endregion
    }
}
