using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Practica
{
    public delegate void Actualizaprogres();
    public class Alumno
    {
        public event Actualizaprogres ActualizarContador;
        public int id;
        public string Nombre;

        public void deserealizarXML(object path)
        {

            XmlTextReader reader;
            XmlSerializer ser;
            Alumno aux = new Alumno();
            reader = new XmlTextReader((string)path);
            ser = new XmlSerializer(typeof(Alumno));
            aux = (Alumno)ser.Deserialize(reader);
            reader.Close();

            this.id = aux.id;
            this.Nombre = aux.Nombre;
            this.Guardar();
            ActualizarContador.Invoke();

        }

    }
}