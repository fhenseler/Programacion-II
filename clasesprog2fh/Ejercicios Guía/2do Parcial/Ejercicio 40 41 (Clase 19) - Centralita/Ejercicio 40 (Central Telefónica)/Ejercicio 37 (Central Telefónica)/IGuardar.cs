using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37__Central_Telefónica_
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo
        {
            get;
            set;
        }
        
        bool Guardar();

        bool Leer();
    }
}
