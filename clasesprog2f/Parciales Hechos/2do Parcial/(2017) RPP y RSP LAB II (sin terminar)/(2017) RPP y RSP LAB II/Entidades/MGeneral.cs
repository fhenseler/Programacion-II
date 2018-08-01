using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Entidades
{
    public class MGeneral : Medico, IMedico<Medico>
    {
        protected override void Atender()
        {
            System.Threading.Thread.Sleep(tiempoAleatorio.Next(1500, 2000));
            //AtencionFinalizada;
            //Escribir en archivo txt
        }

        public void IniciarAtencion(Paciente p)
        {
            Thread th = new Thread(Atender);
            th.Start();
        }

        public MGeneral(string nombre, string apellido)
            :base(nombre, apellido)
        {
        }
    }
}
