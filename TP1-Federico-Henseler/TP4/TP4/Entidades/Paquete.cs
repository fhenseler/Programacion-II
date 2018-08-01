using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    // Implementa la interfaz
    public class Paquete : IMostrar<Paquete>
    {
        #region Fields

        private string direccionEntrega;
        private string trackingID;
        private EEstado estado;

        #endregion
        #region Events

        public event DelegadoEstado InformaEstado;
        //public event DelegadoExcepcion EventoExcepcion;

        #endregion
        #region Nested Types

        public delegate void DelegadoEstado(object sender, EventArgs e);
        //public delegate void DelegadoExcepcion(object sender, EventArgs e);
        public enum EEstado { Ingresado, EnViaje, Entregado };

        #endregion

        #region Properties

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Simula el ciclo de vida de un paquete, cambiando su estado y finalmente guardándolo en la base de datos
        /// </summary>
        /// <returns></returns>
        public void MockCicloDeVida()
        {
            foreach (EEstado estado in Enum.GetValues(typeof(EEstado)))
            {
                this.estado = estado;
                InformaEstado(this.estado, EventArgs.Empty);
                System.Threading.Thread.Sleep(10000);
            }
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                throw e;
            }           
        }

        /// <summary>
        /// Expone los datos del elemento
        /// </summary>
        /// <param name="elemento">Elementos a exponer</param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}", this.trackingID, this.direccionEntrega);
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1.TrackingID == p2.TrackingID);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.TrackingID == p2.TrackingID);
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.TrackingID = trackingID;
            this.DireccionEntrega = direccionEntrega;
        }

        /// <summary>
        /// Retorna la información del Paquete.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        #endregion
    }
}
