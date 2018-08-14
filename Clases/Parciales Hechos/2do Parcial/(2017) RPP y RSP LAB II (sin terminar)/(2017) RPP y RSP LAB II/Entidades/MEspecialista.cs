using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico<Medico>
    {
        private Especialidad especialidad;
        Thread th;

        protected override void Atender()
        {
            System.Threading.Thread.Sleep(tiempoAleatorio.Next(5000, 10000));
            this.FinalizarAtencion();
        }

        public void IniciarAtencion(Paciente p)
        {
            th = new Thread(Atender);
            th.Start();
        }

        public MEspecialista(string nombre, string apellido, Especialidad e)
            :base(nombre, apellido)
        {
            this.especialidad = e;
        }

        public enum Especialidad { Traumatologo, Odontologo };
    }
}
