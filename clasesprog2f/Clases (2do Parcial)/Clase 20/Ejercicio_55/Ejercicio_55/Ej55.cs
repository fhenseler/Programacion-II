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

namespace Ejercicio_55
{
    public partial class Ej55 : Form
    {
        public Ej55()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Busco el Path de una carpeta de sistema
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                // Tomo el nombre del archivo abierto
                string[] partes = openFileDialog1.FileName.Split(Path.DirectorySeparatorChar);
                string file = partes[partes.Length - 1];
                // Genero el nombre del archivo con su correspondiente Path
                string filePath = folder + Path.DirectorySeparatorChar + file;

                //Genero el stream
                FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                //Escrito todo el archivo
                sw.Write(rtb1.Text);
                //Cierro el archivo
                sw.Close();
                fs.Close();

            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Error en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException fex)
            {
                MessageBox.Show(fex.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            toolStripMenuItem1.HideDropDown();
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
             tssi1.Text = string.Format("{0}", rtb1.Text.Length + "caracteres");
             statusStrip1.Refresh();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            string name = openFileDialog1.FileName;
                            // Write to the file name selected.
                            // ... You can write the text from a TextBox instead of a string literal.
                            rtb1.Text = File.ReadAllText(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            toolStripMenuItem1.HideDropDown();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = ".txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.Write(rtb1.Text);
            }
        }

        private void rtb1_TextChanged_1(object sender, EventArgs e)
        {
            tssi1.Text = rtb1.Text.Length + " " + "caracteres";
        }
    }
}
