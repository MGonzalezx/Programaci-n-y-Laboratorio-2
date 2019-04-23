using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
   public class Auto : Vehiculo
  {
    protected int _cantidadAsientos;

    //public string MostrarAuto()
    //{
    //  return base.Mostrar() + " - " + this._cantidadAsientos.ToString();
    //}

    public Auto(int cantidadAsientos, string patente, EMarca marca, byte cantidadRuedas) : base(patente, cantidadRuedas, marca)
    {
      this._cantidadAsientos = cantidadAsientos;
    }
        ///CLASE 10///
        public override string ToString()
        {
            return base.ToString() + " - " + this._cantidadAsientos.ToString();
        }

        public override double Precio { get; set; }
        public override double CalcularPrecioConIVA()
        {
            return this.Precio + (this.Precio * 0.021);
        }
    }
}
