using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace VistaForm
{
    public partial class FormPedido : Form
    {
        private Pedido pedido;
        public ProductoA productoA;
        public ProductoB productoB;
        public List<Producto> productos;
        Thread hilo;

        public FormPedido()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMaterial.DataSource = Enum.GetValues(typeof(Material));
            this.CargarProductosTerminados();
        }

        private void Form1_Closing()
        {
            if (hilo.IsAlive)
                hilo.Abort();
        }

        void TotalizarProductosTerminados(object sender, EventArgs e)
        {
            if (this.lblContadorProductos.InvokeRequired)
            {
                this.lblContadorProductos.BeginInvoke((MethodInvoker)delegate () {
                    this.lblContadorProductos.Text = (int.Parse(lblContadorProductos.Text) + 1).ToString();
                });
            }
            else
                lblContadorProductos.Text = (int.Parse(lblContadorProductos.Text) + 1).ToString();
        }

        void AgregarProductoTerminado(object sender, EventArgs e)
        {
            if (this.lstTerminados.InvokeRequired)
            {
                this.lstTerminados.BeginInvoke((MethodInvoker)delegate () {
                    this.lstTerminados.Items.Add(((Producto)sender).Mostrar());
                });
            }
            else
                this.lstTerminados.Items.Add(((Producto)sender).Mostrar());
        }

        void CargarProductosTerminados()
        {
            //completar
            int count = 0;
            foreach (Producto p in ProductoDAO.ObtenerProductos())
            {
                pedido.Productos.Add(p);
                count++;
            }
            lblContadorProductos.Text = count.ToString();
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            Material material;
            Enum.TryParse<Material>(cmbMaterial.SelectedValue.ToString(), out material);
            //Código alumno
            productoA = new ProductoA(txtDescripcionA.Text, (short)nudDiametro.Value, material);
            productoA.InformarProductoTerminado += this.TotalizarProductosTerminados;
            productoA.InformarProductoTerminado += this.AgregarProductoTerminado;

            this.pedido += productoA;

            this.txtDescripcionA.Text = "";
            this.nudDiametro.Value = 0;
        }

        private void btnAgregarB_Click(object sender, EventArgs e)
        {
            //Código alumno
            productoB = new ProductoB(txtDescripcionB.Text, (short)nudLargo.Value, (short)nudAlto.Value, (short)nudAncho.Value);
            productoB.InformarProductoTerminado += this.TotalizarProductosTerminados;
            productoB.InformarProductoTerminado += this.AgregarProductoTerminado;

            this.pedido += productoB;

            this.txtDescripcionB.Text = "";
            this.nudLargo.Value = 0;
            this.nudAncho.Value = 0;
            this.nudAlto.Value = 0;
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            hilo = new Thread(pedido.FabricarPedido);
            hilo.Start();
        }

    }
}
