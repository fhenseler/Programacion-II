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
    public partial class FormCentralita : Form
    {
        
        public Centralita centralita;
        public FormCentralita()
        {
            InitializeComponent();
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Llamada.TipoLlamada));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmLlamada llama = new FrmLlamada();
            
            this.centralita=new Centralita(txtRazonSocial.Text);
            if (llama.ShowDialog() == DialogResult.OK)
            {
                this.centralita = (Centralita)this.centralita + (Llamada)llama.miLlamada;
                lstbLlamadas.DataSource = this.centralita.Llamadas;
            }
        }
    }
}
