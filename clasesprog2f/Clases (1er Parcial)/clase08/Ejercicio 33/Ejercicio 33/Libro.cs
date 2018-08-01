using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        List<string> paginas = new List<string>();

        public string this[int i]
        { 
            get { return paginas[i]; }
            set { paginas.Add(paginas[i]);}
        }

    }
}
