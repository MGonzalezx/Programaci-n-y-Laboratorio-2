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

    public string MostrarCamion()
    {
      return base.Mostrar() + " - " + this._tara.ToString();
    }

    public Camion(float tara, string patente, EMarca marca, byte cantidadRuedas) : base(patente, cantidadRuedas, marca)
    {
      this._tara = tara;
    }
  }
}
