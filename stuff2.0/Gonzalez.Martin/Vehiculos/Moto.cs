using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Moto : Vehiculo
  {
   
    public double Cilindrada;

    public Moto(double cilindrada, string patente, EMarca marca, int cantidadRuedas) : base(patente, marca, cantidadRuedas)
    {
      this.Cilindrada = cilindrada;
    }

    public string MostrarMoto()
    {
      return base.MostrarVehiculo()  + " - " + this.Cilindrada.ToString();
    }
  }
}
