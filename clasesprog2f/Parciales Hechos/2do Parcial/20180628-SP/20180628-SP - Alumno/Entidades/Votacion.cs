using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Entidades
{
    public class Votacion : SerializarXML
    {
        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        private string nombreLey;
        private Dictionary<string, EVoto> senadores;

        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        public delegate void EventoVotoEfectuado(string senador, Votacion.EVoto voto);
        public event EventoVotoEfectuado Voto;

        public string NombreLey
        {
            get
            {
                return this.nombreLey;
            }
            set
            {
                this.nombreLey = value;
            }
        }

        [XmlIgnore]
        public Dictionary<string, EVoto> Senadores
        {
            get
            {
                return this.senadores;
            }
            set
            {
                this.senadores = value;
            }
        }

        public short ContadorAfirmativo
        {
            get
            {
                return this.contadorAfirmativo;
            }
            set
            {
                this.contadorAfirmativo = value;
            }
        }

        public short ContadorNegativo
        {
            get
            {
                return this.contadorNegativo;
            }
            set
            {
                this.contadorNegativo = value;
            }
        }

        public short ContadorAbstencion
        {
            get
            {
                return this.contadorAbstencion;
            }
            set
            {
                this.contadorAbstencion = value;
            }
        }

        public Votacion()
        {

        }

        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
            :this()
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

        /// <summary>
        /// Simula una votacion, asignandole a cada senador un voto aleatorio
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public void Simular()
        {
            // Reseteo contadores
            this.contadorAbstencion = 0;
            this.contadorAfirmativo = 0;
            this.contadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(50);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key] = (EVoto)r.Next(0, 3);

                // Invocar Evento
                this.Voto.Invoke(k.Key.ToString(), this.senadores[k.Key]);
                // Incrementar contadores
                switch (this.senadores[k.Key])
                {
                    case Votacion.EVoto.Afirmativo:
                        this.contadorAfirmativo += 1;
                        break;
                    case Votacion.EVoto.Negativo:
                        this.contadorNegativo += 1;
                        break;
                    case Votacion.EVoto.Abstencion:
                        this.contadorAbstencion += 1;
                        break;
                }
            }
        }
    }
}
