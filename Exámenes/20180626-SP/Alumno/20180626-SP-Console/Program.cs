using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Threading;

namespace _20180626_SP_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo t = new Torneo("Rusia 2018");
            Console.Title = "Copa Mundial Rusia 2018";

            Grupo grupoD = new Grupo(Letras.D, Torneo.MAX_EQUIPOS_GRUPO);
            grupoD.Leer(grupoD);
            grupoD.Simular();

            // Agregar Thread
            Thread thread = new Thread(t.SimularGrupos);
            thread.Start();
            // **************

            t.Resultado += Program.ImprimirResultados;
            t.Guardar();

            Console.WriteLine("Presione una tecla para continuar…");
            Console.ReadKey();
            Console.Clear();

            Torneo t2 = new Torneo("2do Torneo");
            t2.Leer(grupoD);

            Thread thread2 = new Thread(t2.SimularGrupos);
            thread2.Start();

            t2.Resultado += Program.ImprimirResultados;
            Console.ReadKey();
        }

        public static void ImprimirResultados(Grupo g)
        {
            Console.WriteLine("Grupo {0}", g.Grupos);
            Console.WriteLine("Tabla {0} : ", g.MostrarTabla());
        }
    }

}
