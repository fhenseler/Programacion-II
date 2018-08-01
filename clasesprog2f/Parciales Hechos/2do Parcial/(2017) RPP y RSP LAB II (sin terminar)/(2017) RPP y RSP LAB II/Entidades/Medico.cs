using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        private Paciente pacienteActual;
        protected Random tiempoAleatorio;

        public event FinAtencionPaciente AtencionFinalizada;
        public delegate void FinAtencionPaciente(object sender, EventArgs e);

        public Medico()
            : base()
        {
            this.tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido)
            : base(nombre, apellido)
        {

        }

        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }

        public virtual string EstaAtendiendoA
        {
            get
            {
                return this.pacienteActual.ToString();
            }
        }

        protected abstract void Atender();

        public void FinalizarAtencion()
        {
            AtencionFinalizada(this.pacienteActual, EventArgs.Empty);
            this.pacienteActual = null;
        }
    }
}
