using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Agregar un enumerado con los colores: Natural, Blanco, Negro, Rojo. Utilizar este enumerado en el atributo color de Sofa.
    // Generar una relación de herencia entre Asiento y Sofa.
    // Modificar los atributos y constructores según crea necesario.
    // El método ProbarAsiento hará un Sleep de 3 segundos y retornará true o false de forma aleatoria (Random).

    // Utilizar la teoría de encapsulamiento en todas las clases.    
    public class Sofa : Asiento
    {
        public enum Color { Natural, Blanco, Negro, Rojo };

        //private short alto;
        //private short ancho;
        //private short profundidad;
        private Color colores;

        public Color Colores
        {
            get
            {
                return this.colores;
            }
            set 
            {
                this.colores = value;
            }
        }

        private Sofa(short alto, short ancho, short profundidad)
            :base(alto, ancho, profundidad)
        {

        }

        public Sofa(short alto, short ancho, short profundidad, Color colores)
            : this(alto, ancho, profundidad)
        {
            this.colores = colores;
        }

        /// <summary>
        /// Simula la prueba de un asiento y retorna un bool aleatorio
        /// </summary>
        /// <returns></returns>
        public override void ProbarAsiento()
        {
            System.Threading.Thread.Sleep(5000);
            base.InformarFinDePrueba(true);
        }
    }
}
