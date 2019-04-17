using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
   
    public int CantidadAsientos;

    public Auto (int cantidadAsientos, string patente, EMarca marca, int cantidadRuedas) : base(patente, marca, cantidadRuedas)
    {
      this.CantidadAsientos = cantidadAsientos;
    }

    public string MostrarAuto()
    {
      return base.MostrarVehiculo() + " - " + this.CantidadAsientos.ToString();
    }
    }
}
