using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
  public class Camion : Vehiculo
  {
    protected float _tara;

    //public string MostrarCamion()
    //{
    //  return base.Mostrar() + " - " + this._tara.ToString();
    //}

    public Camion(float tara, string patente, EMarca marca, byte cantidadRuedas) : base(patente, cantidadRuedas, marca)
    {
      this._tara = tara;
    }
        ///CLASE 10///
        public override string ToString()
        {
            return base.ToString() + " - " + this._tara.ToString();
        }

        public override double Precio { get; set; }
        public override double CalcularPrecioConIVA()
        {
            return this.Precio + (this.Precio * 0.021);
        }

    }
}
