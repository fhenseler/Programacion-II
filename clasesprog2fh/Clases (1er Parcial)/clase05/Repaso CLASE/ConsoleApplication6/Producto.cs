using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        protected string codigoDeBarra, marca;
        protected float precio;


        /// <summary>
        /// Inicializo un nuevo Producto, asignando todos sus atributos
        /// </summary>
        /// <param name="marca">Marca comercial del Producto</param>
        /// <param name="codigo">Código de Barras del Producto</param>
        /// <param name="precio">Valor comercial del Producto</param>
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        /// <summary>
        /// Hago público el atributo Marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// Muestro los datos del Producto elegido
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MARCA : " + p.marca);
            sb.AppendLine("CODIGO: " + p.codigoDeBarra);
            sb.AppendLine("PRECIO: " + p.precio);

            //if(p.codigoDeBarra != null && p.marca != null)
            //{
            //    sb.AppendFormat("Marca: {0}, Codigo de Barra: {1}, Precio: {2}", p.marca, p.codigoDeBarra, p.precio);
            //}
            return sb.ToString();
        }

        /// <summary>
        /// Hago público el atributo Código de Barras de un Producto
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool result;
            if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool result;

            if (p.marca == marca)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool result;
            if (object.ReferenceEquals(p1, p2) && p1.codigoDeBarra != p2.codigoDeBarra && p1.marca != p2.marca)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool result;

            if (p.marca != marca)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
