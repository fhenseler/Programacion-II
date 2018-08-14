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

namespace _20180726___Final
{
    // Reutilizar tanto código como sea posible.
    // Primer Parcial: Agregar un atributo del tipo Muebleria e instanciarlo en el constructor.
    // Segundo Parcial y Final
    //   - Agregar un atributo del tipo Lista de Asiento e instanciarlo en el constructor.
    //   - Controlar excepciones en archivos.
    //   - Para el manejo de archivos agregar una interfaz genérica con los métodos V Guardar(string path, T elemento) y T Leer(string path)
    //   - Generar dos clases: ArchivoTexto y ArchivoXML que implementen dicha interfaz. Completar los métodos según corresponda.
    //   - Probar todos los asientos mediante un Thread. Crear un evento FinPruebaCalidad() en Asiento para que informe si la prueba pasó (true) o no (false) y mostrar el resultado por pantalla.
    public partial class FrmPpal : Form
    {
        List<Asiento> lista;
        Thread thread;
        Sofa sofa;
        Random rnd = new Random();

        public FrmPpal()
        {
            InitializeComponent();
            this.sofa = new Sofa(2, 3, 1, Sofa.Color.Blanco);
            this.lista = new List<Asiento>();
        }

        /// <summary>
        /// Primer Parcial: Agregar el elemento a la mueblería.
        /// Segundo Parcial y Final: Al presionar el botón agregar se deberá guardar la información a un archivo, anexando el nuevo Asiento al final. Agregar el elemento a la lista.
        /// Luego, leer el archivo y mostrarlo en el RichTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sofa.Guardar("Archivo.txt", this.sofa);
            this.lista.Add(this.sofa);
            this.rtbMensaje.Text = this.sofa.Leer("Archivo.txt").ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Al abrir el programa se deberá leer el archivo y mostrarlo en el RichTextBox
            this.rtbMensaje.Text = this.sofa.Leer("Archivo.txt").ToString();
        }

        /// <summary>
        /// Antes de cerrar, serializar la lista en XML. Hacer las modificaciones necesarias para guardar todos los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Asiento a in this.lista)
            {
                a.Guardar("Archivo.xml", a);
            }
            if (thread.IsAlive)
                thread.Abort();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            thread = new Thread(this.BancoDePrueba);
            thread.Start();
        }

        /// <summary>
        /// Prueba todos los asientos de la lista
        /// </summary>
        /// <returns></returns>
        public void BancoDePrueba()
        {
            foreach (Asiento a in this.lista)
            {
                a.ProbarAsiento();
            }
        }
    }
}
