using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        protected string codigoDeBarra, marca;
        protected float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1");
            sb.AppendLine("2");
            sb.AppendLine("3");
            sb.AppendFormat("Marca: {0}, Codigo de Barra: {1}, Precio: {2}", p.marca, p.codigoDeBarra, p.precio);

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool result;
            if(p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
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

            if(p.marca == marca)
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
            if (p1.codigoDeBarra != p2.codigoDeBarra && p1.marca != p2.marca)
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
    }
}
