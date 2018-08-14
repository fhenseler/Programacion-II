using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB : Producto
    {
        private short alto;
        private short largo;
        private short ancho;
        
        public short Alto
        {
            get
            {
                return this.alto;
            }
        }

        public short Largo
        {
            get
            {
                return this.largo;
            }
        }

        public short Ancho
        {
            get
            {
                return this.ancho;
            }
        }


        private ProductoB()
        {
           
        }

        public ProductoB(string descripcion, short largo, short alto, short ancho)
            :base(descripcion)
        {
            this.largo = largo;
            this.alto = alto;
            this.ancho = ancho;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(String.Format(", TIPO: {0}, ANCHO: {1}, ALTO: {2}, LARGO: {3}, VOLUMEN: {4}", 'B', this.Ancho, this.Alto, this.Largo, this.CalcularVolumen()));
            return sb.ToString();
        }

        public int CalcularVolumen()
        {
            int volumen = this.ancho * this.alto * this.largo;
            return volumen;
        }

        public override bool ValidarDimensiones()
        {
            bool retorno = false;
            if (this.alto + this.ancho + this.largo <= 100)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
