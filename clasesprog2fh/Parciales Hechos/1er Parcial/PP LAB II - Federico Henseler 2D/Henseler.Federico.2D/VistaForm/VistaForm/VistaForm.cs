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

namespace VistaForm
{
    public partial class VistaForm : Form
    {
        public string nombreProfe;
        public string apellidoProfe;
        public string dniProfe;
        public string nombre;
        public string apellido;
        public string legajo;
        public short anio;
        public Divisiones division;
        public DateTime fechaIngreso;
        public short anioCurso;
        public Divisiones divisionCurso;
        public Curso curso;
        public Alumno alumno;

        public VistaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreProfe = txtNombreProfe.Text;
            apellidoProfe = txtApellidoProfe.Text;
            dniProfe = txtDocumentoProfe.Text;
            fechaIngreso = dtpFechaIngreso.Value;
            anioCurso = (short)nudAnioCurso.Value;
            //divisionCurso = (Divisiones)cmbDivisionCurso.SelectedValue;

            curso = new Curso(anioCurso, divisionCurso, new Profesor(nombreProfe, apellidoProfe, dniProfe, fechaIngreso));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = (string)curso;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            legajo = txtDocumento.Text;
            anio = (short)nudAnio.Value;
            //division = (Divisiones)cmbDivision.SelectedValue;
            alumno = new Alumno(nombre, apellido, legajo, anio, division);

            curso += alumno;
        }

        private void cmbDivisionCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));

            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out divisionCurso);
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));

            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
        }
    }
}
