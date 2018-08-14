using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1 / 1.3642f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        public static implicit operator Euro(double d)
        {
            Euro aux = new Euro(d);
            return aux;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro aux = new Euro(e.cantidad + ((Euro)d).cantidad);
            return aux;
        }
        public static Euro operator +(Euro e, Peso p)
        {
            Euro aux = new Euro(e.cantidad + ((Euro)p).cantidad);
            return aux;
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro aux = new Euro(e.cantidad - ((Euro)d).cantidad);
            return aux;
        }
        public static Euro operator -(Euro e, Peso p)
        {
            Euro aux = new Euro(e.cantidad - ((Euro)p).cantidad);
            return aux;
        }
    }
}
