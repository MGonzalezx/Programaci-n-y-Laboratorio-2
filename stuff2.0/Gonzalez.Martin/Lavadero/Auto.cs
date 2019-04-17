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

    public string MostrarAuto()
    {
      return base.Mostrar() + " - " + this._cantidadAsientos.ToString();
    }

    public Auto(int cantidadAsientos, string patente, EMarca marca, byte cantidadRuedas) : base(patente, cantidadRuedas, marca)
    {
      this._cantidadAsientos = cantidadAsientos;
    }
  }
}
