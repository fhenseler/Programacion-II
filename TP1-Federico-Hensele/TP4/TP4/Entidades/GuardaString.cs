using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Entidades
{
    // Método de Extensión para la clase String
    public static class GuardaString
    {
        #region Methods

        /// <summary>
        /// Guarda un archivo de texto en el escritorio de la máquina
        /// </summary>
        /// <param name="texto">Texto a guardar en el archivo</param>
        /// <param name="archivo">Nombre del archivo</param>
        /// <returns></returns>
        public static void Guardar(this string texto, string archivo)
        {
            string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + archivo;
            using (System.IO.StreamWriter file = new StreamWriter(fullPath, true))
            {
                file.WriteLine(texto);
                file.Close();
            }
        }

        #endregion
    }
}
