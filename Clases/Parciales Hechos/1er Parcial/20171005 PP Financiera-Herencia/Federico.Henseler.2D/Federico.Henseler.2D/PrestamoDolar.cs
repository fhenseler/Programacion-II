using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    class PrestamoDolar : Prestamo
    {
        PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get
            {
                return 1;
            }
        }

        //private float CalcularInteres()
        //{
        //    float totalPrestamo;

        //    if (this.periodicidad == PeriodicidadDePagos.Mensual)
        //    {
        //        totalPrestamo = totalPrestamo + totalPrestamo * 25/100;
        //    }
        //    if (this.periodicidad == PeriodicidadDePagos.Mensual)
        //    {
        //        totalPrestamo = totalPrestamo + totalPrestamo * 25 / 100;
        //    }
        //    if (this.periodicidad == PeriodicidadDePagos.Mensual)
        //    {
        //        totalPrestamo = totalPrestamo + totalPrestamo * 25 / 100;
        //    }
        //}

        public virtual void ExtenderPlazo(DateTime nuevoVencimiento)
        {
        }


    }
}
