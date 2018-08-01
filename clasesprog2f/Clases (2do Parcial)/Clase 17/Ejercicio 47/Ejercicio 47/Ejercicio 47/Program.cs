using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> cont = new Contabilidad<Factura, Recibo>();

            Recibo r1 = new Recibo(111);
            Factura f1 = new Factura(222);
            Recibo r2 = new Recibo(113);
            Factura f2 = new Factura(225);

            cont += r1;
            cont += f1;


            Console.ReadKey();
        }
    }
}
