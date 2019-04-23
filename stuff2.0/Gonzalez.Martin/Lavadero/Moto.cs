using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
  public class Moto : Vehiculo
  {
    protected float _cilindrada;

    //public string MostrarMoto()
    //{
    //  return base.Mostrar() + " - " + this._cilindrada.ToString();
    //}

    public Moto(float cilindrada, string patente, EMarca marca, byte cantidadRuedas) : base(patente, cantidadRuedas, marca)
    {
      this._cilindrada = cilindrada;
    }

        ///CLASE 10///
        public override string ToString()
        {
            return base.ToString() + " - " + this._cilindrada.ToString();
        }

        public override double Precio { get; set; }
        public override double CalcularPrecioConIVA()
        {
            return this.Precio + (this.Precio * 0.021);
        }
    }
}
