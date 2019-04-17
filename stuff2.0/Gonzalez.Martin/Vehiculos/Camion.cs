using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Camion : Vehiculo
  {
   
    public double Tara;

    public Camion(double tara, string patente, EMarca marca, int cantidadRuedas) : base(patente, marca, cantidadRuedas)
    {
      this.Tara = tara;
    }

    public string MostrarCamion()
    {
      return base.MostrarVehiculo() + " - " + this.Tara.ToString();
    }
  }
}
