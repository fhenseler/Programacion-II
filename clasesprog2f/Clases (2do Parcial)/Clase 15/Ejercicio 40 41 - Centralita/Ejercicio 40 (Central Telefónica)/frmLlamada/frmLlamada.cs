using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_37__Central_Telefónica_;

namespace frmLlamada
{
    public partial class frmLlamada : Form
    {
        public Llamada millamada;

        public frmLlamada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            	if(cmbTipo.SelectedItem == "Local")
	            {
		            this.miLlamada = new Local(duracion, destino, origen);
	            }
	            else
	            {
		            this.miLlamada = new Provincial(miFranja, llamada);
		            this.DialogResult == DialogResult ;
		            this.close();
	            }
        }
    }
}
