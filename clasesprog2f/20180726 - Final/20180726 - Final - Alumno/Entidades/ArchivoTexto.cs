using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excepciones;

namespace Entidades
{
    public class ArchivoTexto : IArchivos<Asiento, bool>
    {
        Asiento datos;

        /// <summary>
        /// Lee un objeto del tipo Asiento desde un archivo de texto
        /// </summary>
        /// <param name="path">Ruta del archivo</param>
        /// <returns></returns>
        public Asiento Leer(string path)
        {
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(path))
                {
                    //datos = file.ReadToEnd();
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }

        /// <summary>
        /// Guarda un objeto del tipo Asiento en un archivo de texto
        /// </summary>
        /// <param name="path">Ruta del archivo</param>
        /// <returns></returns>
        public bool Guardar(string path, Asiento elemento)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    file.WriteLine(elemento);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }
    }

}
