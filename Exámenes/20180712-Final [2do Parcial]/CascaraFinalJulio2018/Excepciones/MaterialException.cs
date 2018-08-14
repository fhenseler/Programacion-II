using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MaterialException : Exception
    {
        public MaterialException(Exception e)
            : base("No se puede fabricar una pieza de MATERIAL y DIAMETRO", e)
        {
        }
    }
}
