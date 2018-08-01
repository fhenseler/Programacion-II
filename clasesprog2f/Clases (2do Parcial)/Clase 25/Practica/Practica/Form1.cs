using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.xml");

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                string[] paths = Directory.GetFiles(textBox1.Text);
                progressBar1.Maximum = paths.Length;
                progressBar1.Value = 0;

                Alumno al = new Alumno();
                al.ActualizarContador += actualizaProgressBar;

                foreach (string item in paths)
                {
                    Thread t1 = new Thread(new ParameterizedThreadStart(al.deserealizarXML));
                    t1.Start(item);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una carpeta correcta");
                textBox1.Focus();
            }
        }

        public void actualizaProgressBar()
        {
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.progressBar1.Value = this.progressBar1.Value + 1;
                });

            }
            else
                this.progressBar1.Value = this.progressBar1.Value + 1;
        }
   }
}
      
