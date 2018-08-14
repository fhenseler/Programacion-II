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
                    ValidarMaterial(this.Material);
                }
                catch(MaterialException e)
                {
                    throw e;
                }
            }
        }

        private ProductoA()
        {

        }

        public ProductoA(string descripcion, short diametro, Material material)
            :base(descripcion)
        {
            this.diametro = diametro;
            this.material = material;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(String.Format("DESCRIPCION: {0}, TIPO: {1}, DIAMETRO: {2}, MATERIAL: {3}", this.Descripcion, 'A', this.Diametro, this.Material));
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
        }
}
