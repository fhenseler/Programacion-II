using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excepciones;


namespace Entidades
{

    public class ProductoA : Producto
    {
        private short diametro;
        private Material material;

        public short Diametro
        {
            get
            {
                return this.diametro;
            }
        }

        public Material Material
        {
            get
            {
                return this.material;
            }
            set
            {
                try
                {
                    if(!(ValidarMaterial(this.Material)))
                        throw new MaterialException("No se puede fabricar una pieza de {0} y diámetro de {1} centímetros." + this.Material + this.Diametro); 
                }
                catch (MaterialException e)
                {
                    throw e;
                }
            }
        }

        private ProductoA()
        {

        }

        public ProductoA(string descripcion, short diametro, Material material)
            : base(descripcion)
        {
            this.diametro = diametro;
            this.material = material;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(" ");
            sb.Append(String.Format(", TIPO: {0}, DIAMETRO: {1}, MATERIAL: {2}", 'A', this.Diametro, this.Material));
            return sb.ToString();
        }

        public bool ValidarMaterial(Material unMaterial)
        {
            bool retorno = false;
            switch (unMaterial)
            {
                case Material.Aluminio:
                    if (this.diametro <= 10)
                        retorno = true;
                    break;

                case Material.Caucho:
                    if (this.diametro <= 15)
                        retorno = true;
                    break;

                case Material.Plastico:
                    retorno = true;
                    break;
            }
            return retorno;
        }

        public override bool ValidarDimensiones()
        {
            bool retorno = false;
            if(this.diametro % 2 == 0 && (this.diametro >= 30 && this.diametro <= 50))
            {
                retorno = true;
            }
            return retorno;           
        }
    }
}
