using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private int turno;
        private static int ultimoTurnoDado;

        public int Turno
        {
            get
            {
                return this.turno;
            }
        }

        static Paciente()
        {
            Paciente.ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido)
            :base(nombre, apellido)
        {
            Paciente.ultimoTurnoDado += 1;
            turno = Paciente.ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido, int turno)
            : this(nombre, apellido)
        {
            this.turno = turno;
            Paciente.ultimoTurnoDado = this.turno;
        }

        public override string ToString()
        {
            return String.Format("Turno Nº{0}: {2}, {1}", this.turno, this.apellido, this.nombre);
        }
    }
}
