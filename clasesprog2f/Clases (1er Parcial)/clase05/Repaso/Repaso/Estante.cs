using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;
        int capacidad; //??

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Estante(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public Producto[] GetProductos
        {
            get { return productos; }
        }

        public string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1");
            sb.AppendLine("2");
            sb.AppendLine("3");
            sb.AppendFormat("Capacidad: {0}, Ubicacion: {1}, Productos: {2}", e.capacidad, e.ubicacionEstante, e.productos);

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
            return sb.ToString();
        }

        //public static bool operator ==(Estante e, Producto p)
        //{
        //    bool result;
        //    if ()
        //    {
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool operator !=(estante e, producto p)
        //{
        //    bool result;
        //    if ()
        //    {
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool operator +(Estante e, Producto p)
        //{
        //    e.
        //    return result;
        //}

        //public static bool operator -(Estante e, Producto p)
        //{
        //    bool result;
        //    if (e.capacidad < p.length)
        //    {
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}
    }
}
