using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class PuntoTxt : Archivo, IArchivo<string>
    {
        public bool Guardar(string ruta)
        {
            return true;
        }

        public string Leer(string ruta)
        {
            return "";
        }

        bool ValidarArchivo(string ruta)
        {
            if (File.Exists(ruta) && CheckFileType(ruta))
            {
                return true;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".txt":
                    return true;
                default:
                    return false;
            }
        }
    }
}
