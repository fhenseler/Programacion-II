using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    // Redefinir ToString para que retorne la información del Asiento de forma ordenada. Utilizar string.Format o StringBuilder.
    // Utilizar la teoría de encapsulamiento en todas las clases.
    // La clase debe ser abstracta
    // Crear un método abstracto llamado ProbarAsiento que retorne un bool.
    [Serializable()] 
    public abstract class Asiento : ArchivoXML
    {
        private short alto;
        private short ancho;
        private short profundidad;

        public delegate void ProductoTerminado(Object sender, EventArgs e);
        public event ProductoTerminado FinPruebaCalidad;

        [XmlElement("Alto")]
        public short Alto
        {
            get
            {
                return this.alto;
            }
            set
            {
                this.alto = value;
            }
        }

        [XmlElement("Ancho")]
        public short Ancho
        {
            get
            {
                return this.ancho;
            }
            set
            {
                this.ancho = value;
            }
        }

        [XmlElement("Profundidad")]
        public short Profundidad
        {
            get
            {
                return this.profundidad;
            }
            set
            {
                this.profundidad = value;
            }
        }

        public Asiento(short alto, short ancho, short profundidad)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
        }

        /// <summary>
        /// Retorna un string con toda la informacion del asiento
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("ALTO: {0}, ANCHO: {1}, PROFUNDIDAD: {2}", this.Alto, this.Ancho, this.Profundidad);
        }

        public void InformarFinDePrueba(bool elemento)
        {
            this.FinPruebaCalidad(this.ToString(), EventArgs.Empty);
        }

        public abstract void ProbarAsiento();
    }
}
