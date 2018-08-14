using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {
        public Dulce(EMarca marca, string codigo, ConsoleColor color)
            :base(marca, codigo, color)
        {
        }
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// Publica todos los datos del Dulce.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");

            sb.Append(base.Mostrar());

            sb.AppendLine("");
            sb.AppendLine("CALORIAS: " + this.CantidadCalorias);
 
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
