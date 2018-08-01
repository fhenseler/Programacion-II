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
using frmLlamada;

namespace frmCentralita
{
    public partial class frmCentralita : Form
    {
        public frmCentralita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            	frmLlamada llamada = new frmLlamada();

	            if(llamada.showDialog() == DialogResult)
	            {
		            centralita + llamada.miLlamada;
	            }
        }
    }
}
