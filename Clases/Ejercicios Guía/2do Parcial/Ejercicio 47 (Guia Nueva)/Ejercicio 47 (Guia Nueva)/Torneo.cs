using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47__Guia_Nueva_
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public static bool operator ==(Torneo<T> t, Equipo e)
        {
            foreach (Equipo aux in t.equipos)
            {
                if (e == aux)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, Equipo e)
        {
            return !(t == e);
        }
    }
}
