using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Ej56
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(Persona p)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                TextWriter writer = new StreamWriter("test.xml");
                //XmlTextWriter writer = new XmlTextWriter("test.xml", Encoding.UTF8);
                serializer.Serialize(writer, p);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool Leer(string archivo, out Persona p)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                TextReader writer = new StreamReader(archivo);
                //XmlTextReader writer = new XmlTextReader(archivo);
                p = (Persona)serializer.Deserialize(writer);
                writer.Close();

                return true;
            }
            catch (Exception)
            {
                p = default(Persona);
                return false;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre  : " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
