using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        #region Fields

        Correo correo = new Correo();

        #endregion

        #region Methods

        public FrmPpal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia los 3 ListBox y luego recorre la lista de paquetes agregando
        /// cada uno de ellos en el listado que corresponda.
        /// </summary>
        /// <returns></returns>
        private void ActualizarEstados()
        {
            lstEstadoIngresado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoEntregado.Items.Clear();

            foreach (Paquete p in correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(p);
                        lstEstadoIngresado.Text = p.MostrarDatos(p);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(p);
                        lstEstadoEnViaje.Text = p.MostrarDatos(p);
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(p);
                        lstEstadoEntregado.Text = p.MostrarDatos(p);
                        break;
                    default:
                        break;
                }
            }

            lstEstadoIngresado.ClearSelected();
            lstEstadoEnViaje.ClearSelected();
            lstEstadoEntregado.ClearSelected();
        }

        /// <summary>
        /// Crea un nuevo paquete y lo agrega al correo. 
        /// Actualiza los listbox según el estado de los paquetes
        /// </summary>
        /// <returns></returns>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            p.InformaEstado += new Paquete.DelegadoEstado(paq_InformaEstado);

            try
            {
                correo += p;
            }
            catch(TrackingIdRepetidoException tire)
            {
                MessageBox.Show(tire.Message, "Paquete repetido");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            ActualizarEstados();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(elemento != null)
            {
                rtbMostrar.Text = elemento.MostrarDatos(elemento);
                rtbMostrar.Text.Guardar("salida.txt");
            }
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            mtxtTrackingID.Select();
        }

        private void FrmPpal_Closing(object sender, EventArgs e)
        {
            correo.FinEntregas();
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            { // Llamar al método }
                this.ActualizarEstados();
            }
        }

        private void cmsListas_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

    #endregion
    }
}
