using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    class PuntoDat : Archivo, IArchivo<PuntoDat>
    {
        private string contenido;

        public bool Guardar(string ruta)
        {
            FileStream fs;        //Objeto que escribirá en binario.
            BinaryFormatter ser;  //Objeto que serializará.

            fs = new FileStream(ruta, FileMode.Create);
            //Se indica ubicación del archivo binario y el modo.
            ser = new BinaryFormatter();
            //Se crea el objeto serializador.
            ser.Serialize(fs, ruta);
            //Serializa el objeto p en el archivo contenido en fs.
            fs.Close();
            //Se cierra el objeto fs.
            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat aux = new PuntoDat();
            FileStream fs;                  //Objeto que leerá en binario.
            BinaryFormatter ser;      //Objeto que Deserializará.

            fs = new FileStream(ruta, FileMode.Open);
            //Se indica ubicación del archivo binario y el modo.
            ser = new BinaryFormatter();
            //Se crea el objeto deserializador.
            aux = (PuntoDat)ser.Deserialize(fs);
            //Deserializa el archivo contenido en fs, lo guarda 
            //en aux.
            fs.Close();
            //Se cierra el objeto fs.
            return aux;
        }

        string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        bool ValidarArchivo(string ruta)
        {
            try
            {
                if(File.Exists(ruta))
                    return true;
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            try
            {
                if (CheckFileType(ruta))
                    return true;
            }
            catch(ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es un .dat", e);
            }
            return false;

        }

        bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".dat":
                    return true;
                default:
                    return false;
            }
        }
    }
}
