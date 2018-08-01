using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Snacks : Producto
    {
        public Snacks(EMarca marca, string codigo, ConsoleColor color)
            : base(marca, codigo, color)
        {
        }
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        /// <summary>
        /// Publica todos los datos del Snack.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");

            sb.Append(base.Mostrar());
      
            sb.AppendLine("");
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
