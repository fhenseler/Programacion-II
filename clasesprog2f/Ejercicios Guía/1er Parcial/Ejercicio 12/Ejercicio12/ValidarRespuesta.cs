using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class ValidarRespuesta
    {
        static public bool ValidaS_N(char c)
        {
            bool retorno;

            if (c == 'S')
                retorno = true;
            else
                retorno = false;

            return retorno;
        }
    }
}
