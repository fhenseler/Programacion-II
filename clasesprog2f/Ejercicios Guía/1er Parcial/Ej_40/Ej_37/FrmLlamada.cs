using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_40
{
    public partial class FrmLlamada : Form
    {
        public FrmLlamada()
        {
            InitializeComponent();
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Llamada.TipoLlamada));
        }

        public Llamada miLlamada;
        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem == "Local")
            {
                this.miLlamada = new Local(txtOrigen.Text, float.Parse(txtDuracion.Text), txtDestino.Text, 0.5f);
            }
            else
            {
                this.miLlamada = new Provincial(txtOrigen.Text, txtDestino.Text, float.Parse(txtDuracion.Text), Provincial.Franja.Franja_2);
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
