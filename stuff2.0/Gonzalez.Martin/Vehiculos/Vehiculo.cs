using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Vehiculo
  {
    public string Patente;
    public EMarca Marca;
    public int CantidadRuedas;

    public Vehiculo ( string patente, EMarca marca, int cantidadRuedas)
    {
      this.Patente = patente;
      this.Marca = marca;
      this.CantidadRuedas = cantidadRuedas;
    }

    public string MostrarVehiculo()
    {
      return this.Patente + " - " + this.Marca + " - " + this.CantidadRuedas.ToString();
    }
  }
}
