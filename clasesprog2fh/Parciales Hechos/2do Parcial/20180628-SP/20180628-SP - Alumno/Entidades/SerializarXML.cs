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
    public class SerializarXML : IArchivos<Votacion>
    {
        Votacion datos;

        /// <summary>
        /// Lee un archivo XML y lo deserializa
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo XML a deserializar</param>
        /// <returns></returns>
        public Votacion Leer(string rutaArchivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Votacion));
                TextReader writer = new StreamReader(rutaArchivo);
                datos = (Votacion)serializer.Deserialize(writer);
                writer.Close();

                return datos;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
        }

        /// <summary>
        /// Guarda un objeto del tipo Votacion en un archivo XML
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo</param>
        /// /// <param name="objeto">Objeto del tipo votacion a serializar</param>
        /// <returns></returns>
        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Votacion));
                TextWriter writer = new StreamWriter(rutaArchivo);
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
