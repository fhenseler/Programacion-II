using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        List<string> paginas = new List<string>(100);

        public string this[int i]
        { 
            get 
            {
                string retorno = "";
                if (i > 0 && i <= paginas.Count)
                {
                   retorno = paginas[i];
                }
                return retorno;
            }
            set
            {
                if(i < paginas.Count)
                paginas[i] = value;
            }
        }

    }
}
