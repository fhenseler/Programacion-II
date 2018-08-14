using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Material { Plastico, Aluminio, Caucho };

    public abstract class Producto
    {
        private string descripcion;

        public delegate void ProductoTerminado(Object sender, EventArgs e);
        public event ProductoTerminado InformarProductoTerminado;

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public Producto()
        {

        }

        public Producto(string descripcion)
            :this()
        {
            this.descripcion = descripcion;
        }


        public virtual string Mostrar()
        {
            return String.Format("DESCRIPCION: {0}", this.Descripcion);
        }

        public void Elaborar()
        {
            try
            {
                ProductoDAO.GuardarProducto(this);
            }
            catch (Exception e)
            {
                throw e;
            }  
            
            //this.InformarProductoTerminado.Invoke(this.Mostrar(), EventArgs.Empty);
            this.InformarProductoTerminado(this.Mostrar(), EventArgs.Empty);
        }

        public abstract bool ValidarDimensiones();
    }
}
