using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        string num1 = "";
        string num2 = "";
        string operador = "";

        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
            num1 = txtNumero1.Text;
            num2 = txtNumero2.Text;
            operador = cmbOperador.Text;

            double result = Operar(num1, num2, operador);
            lblResultado.Text = result.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = false;
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = false;
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text).ToString();
        }

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
            if(lblResultado.Text != "0")
            {
                btnConvertirADecimal.Enabled = true;
                btnConvertirABinario.Enabled = true;
            }
        }

        public void Limpiar()
        {
            this.cmbOperador.Text = String.Empty;
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = String.Empty;
        }

        public static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }
    }
}
