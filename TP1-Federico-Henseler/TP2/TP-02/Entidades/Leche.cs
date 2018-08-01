using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo _tipo;

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color)
            :base(marca, codigo, color)
        {
        }

        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo)
            :this(marca, codigo, color)
        {
            this._tipo = ETipo.Entera;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        /// <summary>
        /// Publica todos los datos de la Leche.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");

            sb.Append(base.Mostrar());

            sb.AppendLine("");
            sb.AppendLine("CALORIAS: " + this.CantidadCalorias);
            sb.AppendLine("TIPO: " + this._tipo);
            
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
