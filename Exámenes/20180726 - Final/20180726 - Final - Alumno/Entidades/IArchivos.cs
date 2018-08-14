using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T, V>
    {
        T Leer(string path);
        V Guardar(string path, T elemento);
    }
}
