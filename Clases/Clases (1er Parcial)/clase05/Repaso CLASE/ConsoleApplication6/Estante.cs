using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        /// <summary>
        /// Inicializo un nuevo estante, inicializando la lista según una capacidad.
        /// </summary>
        /// <param name="capacidad">Cantidad de productos que podrá contener el estante.</param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("======================ESTANTE======================");
            sb.AppendLine("UBICACION: " + e.ubicacionEstante);
            sb.AppendLine("CAPACIDAD: " + e.productos.Length);
            sb.AppendLine("PRODUCTOS:");
            foreach (Producto p in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }
            //sb.AppendFormat("Ubicación: {0}", e.ubicacionEstante);
            //sb.AppendLine("");
            //sb.AppendFormat("Capacidad: {0}", e.productos.Length);
            //sb.AppendLine("");
            //sb.AppendLine("Productos: ");
            //for (int i = 0; i < e.productos.Length; i++)
            //{
            //    sb.AppendFormat("{0}", Producto.MostrarProducto(e.productos[i]));
            //    sb.AppendLine("");
            //}
            //foreach (Producto p in e.productos)
            //{
            //    sb.AppendLine(Producto.MostrarProducto(p));
            //}
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {

            // Recorro la lista de productos del estante...
            foreach (Producto aux in e.productos)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(aux, null))
                {
                    // Utilizo la sobrecarga del == de Producto
                    if (p == aux)
                    {
                        return true;
                    }
                }
            }
            return false;
            //bool result = false;
            //for (int i = 0; i < e.productos.Length; i++)
            //{
            //    if (!object.ReferenceEquals(e.productos[i], null))
            //    {
            //        if (e.productos[i] == p)
            //        {
            //            result = true;
            //        }
            //    }
            //}
            //return result;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            // Si el Estante no contiene el Producto...
            if (e != p)
            {
                // Recorro la lista de productos del estante...
                for (int i = 0; i < e.productos.Length; i++)
                {
                    // Busco un espacio vacio
                    if (object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        // Si agregué, rompo el lazo para no volver a agregarlo.
                        return true;
                    }
                }
            }
            // Si no salió hasta acá es porque no agregó el ítem
            return false;
            //bool result = true;

            ////for (int i = 0; i < e.productos.Length; i++)
            ////{
            ////    if (e.productos[i] == p)
            ////    {
            ////        result = false;
            ////        break;
            ////    }
            ////}
            
            //if (e != p)
            //{
            //    if (result == true)
            //    {
            //        for (int i = 0; i < e.productos.Length; i++)
            //        {
            //            if (object.ReferenceEquals(e.productos[i], null))
            //            {
            //                e.productos[i] = p;
            //                break;
            //            }
            //        }
            //    }
            //}
            //return result;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            // Recorro la lista de productos del estante...
            for (int i = 0; i < e.productos.Length; i++)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(e.productos[i], null))
                {
                    // Utilizo la sobrecarga del == de Producto
                    if (p == e.productos[i])
                    {
                        // Vacio el espacio que ocupaba dicho Producto
                        e.productos[i] = null;
                        // Rompo el lazo
                        break;
                    }
                }
            }
            return e;
            //for (int i = 0; i < e.productos.Length; i++)
            //{
            //    if (!object.ReferenceEquals(e.productos[i], null))
            //    {
            //        if (e.productos[i] == p)
            //        {
            //            e.productos[i] = null;
            //            break;
            //        }
            //    }
            //}
            //return e;
        }
    }
}