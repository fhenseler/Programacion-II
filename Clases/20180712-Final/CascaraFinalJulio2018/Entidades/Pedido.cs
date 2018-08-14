using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private List<Producto> productos;

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }

        public Pedido()
        {
            this.productos = new List<Producto>();
        }

        public static Pedido operator +(Pedido unPedido, Producto unProducto)
        {
            foreach (Producto p in unPedido.productos)
            {
                if (unPedido.productos.Count < 5 && p.ValidarDimensiones()) 
                    unPedido.productos.Add(unProducto);
            }
            return unPedido;
        }

        public void FabricarPedido()
        {
            foreach (Producto p in this.productos)
            {
                System.Threading.Thread.Sleep(1000);
                p.Elaborar();
            }
        }

        public static implicit operator String(Pedido unPedido)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(unPedido.Productos.ToString());
            return sb.ToString();
        }
    }
}
