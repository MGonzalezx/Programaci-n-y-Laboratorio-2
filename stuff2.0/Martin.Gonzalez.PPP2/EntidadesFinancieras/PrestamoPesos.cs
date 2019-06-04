using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        //PROPIEEDADES
        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        //METODOS
        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }

        //CalcularInteres: Método privado de instancia que calculará y retornará el total del préstamo.
        //Este método será accedido a través de una propiedad de lectura llamada Interes cuyo valor será
        //utilizado en la clase Financiera dentro del método CalcularInteresGanado
        private float CalcularInteres()
        {
            return (this.Monto * ((this.porcentajeInteres) / 100));
        }


        //ExtenderPlazo: Deberá implementarse el método abstracto definido en la clase base.
        //i.En el caso de los préstamos en pesos, se deberá aplicar un incremento del 0.25% al interés
        //original por cada día de extendido el plazo y se actualizará la fecha original de vencimiento a
        //la nueva fecha
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.porcentajeInteres += ((nuevoVencimiento - this.Vencimiento).Days) * (float)0.25;
            base.vencimiento = nuevoVencimiento;
        }

        //Mostrar: Retornará una cadena con los atributos de la clase base, los propios de la clase y la
        //propiedad Interes.Utilizar StringBuilder para concatenar los String a mostrar (no utilizar el
        //operador +).

        public override string Mostrar()
        {
            return base.Mostrar() + " - Porcenta Interes: " + this.porcentajeInteres.ToString() + " - Interes: " + this.Interes.ToString() + "\n";
        }

    }
}
