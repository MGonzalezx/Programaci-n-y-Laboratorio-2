using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePago periodicidad;

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePago Periodicidad
        {
            get { return periodicidad; }
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePago periodicidad) : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePago periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }

        //Para los préstamos en dólares el porcentaje de interés estará dado por la periodicidad de
        //pago(Mensual: 25, Bimestral: 35, Trimestral: 40).
        private float CalcularInteres()
        {
            if (this.periodicidad == PeriodicidadDePago.Mensual)
            {
                return this.monto * (float)0.25;
            }
            else if (this.periodicidad == PeriodicidadDePago.Bimestral)
            {
                return this.monto * (float)0.35;
            }
            else
            {
                return this.monto * (float)0.4;
            }
        }

        //Para los préstamos en dólares se incrementará el monto original en 2.5 dólares por cada día
        //de extendido el plazo y se actualizará la fecha original de vencimiento a la nueva fecha.
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.monto += ((nuevoVencimiento - this.Vencimiento).Days) * (float)2.5;
            base.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + " - Periodicidad: " + this.periodicidad.ToString() + " - Interes: " + this.Interes.ToString() + "\n";
        }
    }
}
