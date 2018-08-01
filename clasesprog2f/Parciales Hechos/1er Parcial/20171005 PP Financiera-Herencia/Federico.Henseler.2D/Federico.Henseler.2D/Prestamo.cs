using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum TipoDePrestamo { Pesos, Dolares, Todos };
    public enum PeriodicidadDePagos { Mensual, Bimestral, Trimestral };
    
    abstract class Prestamo
    {
        private float monto;
        private DateTime vencimiento;

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if (this.vencimiento > DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno = 0;
            if (p1.vencimiento > p2.vencimiento)
            {
                retorno = 1;
            }
            if (p1.vencimiento < p2.vencimiento)
            {
                retorno = -1;
            }
            return retorno;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento)
        { 
        }

        protected virtual string Mostrar()
        {
            string retorno = String.Format("Monto: {0} -- Vencimiento: {1}", this.monto, this.vencimiento);
            return retorno;
        }
    }
}
