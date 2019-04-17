using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Vehiculo
    {
    protected string _patente;
    protected byte _cantRuedas;
    protected EMarca _marca;

    protected string Mostrar()
    {
      return this._patente + " - " + this._cantRuedas.ToString() + " - " + this._marca;
    }

    public Vehiculo(string patente, byte cantidadRuedas, EMarca marca)
    {
      this._patente = patente;
      this._cantRuedas = cantidadRuedas;
      this._marca = marca;
    }

    public static bool operator == (Vehiculo patentes, Vehiculo marcas)
    {
      bool retorno = false;
      if (Vehiculo.Equals(patentes, null) && Vehiculo.Equals(marcas, null))
      {
        retorno = true;
      }
      return retorno;
    }

    public static bool operator !=(Vehiculo patentes, Vehiculo marcas)
    {
      return !(patentes == marcas);
    }
  }
}
