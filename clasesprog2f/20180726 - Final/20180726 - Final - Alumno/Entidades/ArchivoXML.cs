using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class ArchivoXML : IArchivos<Asiento, bool>
    {
        public Asiento asiento;

        /// <summary>
        /// Lee un archivo XML y lo deserializa
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo XML a deserializar</param>
        /// <returns></returns>
        public Asiento Leer(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Asiento));
                TextReader writer = new StreamReader(path);
                asiento = (Asiento)serializer.Deserialize(writer);
                writer.Close();

                return asiento;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }

        /// <summary>
        /// Guarda un objeto del tipo Asiento en un archivo XML
        /// </summary>
        /// <param name="path">Ruta del archivo</param>
        /// /// <param name="objeto">Objeto del tipo Asiento a serializar</param>
        /// <returns></returns>
        public bool Guardar(string path, Asiento objeto)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Asiento));
                TextWriter writer = new StreamWriter(path);
                serializer.Serialize(writer, objeto);
                writer.Close();                
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }
    }
}

