using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Peso
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Peso()
        {
            Peso.cotizRespectoDolar = 17.55f;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, float cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }
        
        public static float GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion());
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }
        public static implicit operator Peso(double d)
        {
            Peso aux = new Peso(d);
            return aux;
        }

        public static bool operator !=(Peso p, Dolar d)  
        {
            return !(p == d);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return p == (Peso)d;
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            Peso aux = new Peso(p.cantidad + ((Peso)d).cantidad);
            return aux;
        }
        public static Peso operator +(Peso p, Euro e)
        {
            Peso aux = new Peso(p.cantidad + ((Peso)e).cantidad);
            return aux;
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            Peso aux = new Peso(p.cantidad - ((Peso)d).cantidad);
            return aux;
        }
        public static Peso operator -(Peso p, Euro e)
        {
            Peso aux = new Peso(p.cantidad - ((Peso)e).cantidad);
            return aux;
        }
    }
}
