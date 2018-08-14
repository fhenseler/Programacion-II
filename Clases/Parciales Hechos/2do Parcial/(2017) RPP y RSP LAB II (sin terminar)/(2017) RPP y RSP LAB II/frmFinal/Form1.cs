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

namespace Entidades
{
    public partial class frmFinal : Form
    {
        MEspecialista medicoEspecialista;
        MGeneral medicoGeneral;
        Paciente paciente = new Paciente("asd", "www");
        Thread mocker;
        Queue<Paciente> pacientesEnEspera;

        public frmFinal()
        {
            InitializeComponent();

            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            this.pacientesEnEspera = new Queue<Paciente>();
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            mocker = new Thread(MockPacientes);
        }

        private void frmFinal_FormClosing(object sender, EventArgs e)
        {
            this.mocker.Abort();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(medicoGeneral);
        }

        private void btnEspecialista_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(medicoEspecialista);
        }

        private void AtenderPacientes(IMedico<Medico> iMedico)
        {
            if (pacientesEnEspera.Count > 0)
            {
                if (iMedico is MEspecialista)
                {
                    medicoEspecialista.IniciarAtencion(pacientesEnEspera.Dequeue());
                }
                if (iMedico is MGeneral)
                {
                    medicoGeneral.IniciarAtencion(pacientesEnEspera.Dequeue());
                }
            }
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            MessageBox.Show("Finalizó la atención de {0} por {1}!", p.nombre + m.nombre);
        } 

        private void MockPacientes()
        {
            this.pacientesEnEspera.Enqueue(paciente);
            Thread.Sleep(5000);
        }
    }
}
