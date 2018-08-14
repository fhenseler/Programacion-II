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
    public class Torneo : IEntradaSalida<bool>
    {
        private List<Grupo> grupos;
        private string nombre;

        public delegate void EventoResultados(Grupo g);
        public event EventoResultados Resultado;

        public const int MAX_EQUIPOS_GRUPO = 4;

        public List<Grupo> Grupos
        {
            get
            {
                return this.grupos;
            }
            set
            {
                this.grupos = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;
        }


        /// <summary>
        /// Lee un archivo XML y lo deserializa
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo XML a deserializar</param>
        /// <returns></returns>
        public bool Leer(Grupo x)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Grupo));
                TextReader writer = new StreamReader("grupo-" + x.Grupos + ".xml");
                this.grupos.Add((Grupo)serializer.Deserialize(writer));
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Guarda un objeto del tipo Votacion en un archivo XML
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo</param>
        /// /// <param name="objeto">Objeto del tipo votacion a serializar</param>
        /// <returns></returns>
        public bool Guardar()
        {
            try
            {
                foreach(Grupo g in this.grupos)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Grupo));
                    TextWriter writer = new StreamWriter("grupo-" + g.Grupos + ".xml");
                    serializer.Serialize(writer, g);
                    writer.Close();
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SimularGrupos()
        {
            foreach(Grupo g in this.grupos)
            {
                g.Simular();
                this.Resultado.Invoke(g);
            }
        }
    }
}
