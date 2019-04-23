using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
  public class Lavadero
  {
    private List<Vehiculo> _vehiculos;
    private float _precioAuto;
    private float _precioCamion;
    private float _precioMoto;


    public List<Vehiculo> MisVehiculos
    {
      get { return _vehiculos; }
    }

    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    public Lavadero( float precioAuto, float precioCamion, float precioMoto): this()
    {
      this._precioAuto = precioAuto;
      this._precioMoto = precioMoto;
      this._precioCamion = precioCamion;
    }

    public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
    {
      return lavadero.MisVehiculos.Contains(vehiculo);
    }

    public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
    {
      return !(lavadero == vehiculo);
    }

    public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
    {
      if (lavadero != vehiculo)
      {
        lavadero.MisVehiculos.Add(vehiculo);
      }
      return lavadero;
    }

    public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
    {
      if (lavadero == vehiculo)
      {
        lavadero.MisVehiculos.Remove(vehiculo);
      }
      return lavadero;
    }

    public double MostrarTotalFacturado()
    {
      double retorno = 0;
      foreach(Vehiculo vehiculo in this.MisVehiculos)
      {
        if(vehiculo is Auto)
        {
          retorno += this._precioAuto;
        }else if (vehiculo is Moto)
        {
          retorno += this._precioMoto;
        }else if (vehiculo is Camion)
        {
          retorno += this._precioCamion;
        }
      }
      return retorno;
    }

    public double MostrarTotalFacturado(EVehiculos eVehiculo)
    {
      double retorno = 0;
      if (eVehiculo == EVehiculos.Auto)
      {
        foreach (Vehiculo vehiculo in this.MisVehiculos)
        {
          if (vehiculo is Auto)
          {
            retorno += this._precioAuto;
          }
        }
      }else if(eVehiculo == EVehiculos.Camion)
      {
        foreach (Vehiculo vehiculo in this.MisVehiculos)
        {
          if (vehiculo is Camion)
          {
            retorno += this._precioCamion;
          }
        }
      }else if (eVehiculo == EVehiculos.Moto)
      {
        foreach (Vehiculo vehiculo in this.MisVehiculos)
        {
          if (vehiculo is Moto)
          {
            retorno += this._precioMoto;
          }
        }
      }
      return retorno;
    }

    public static int OrdenarVehiculosPorPatente(Lavadero vehiculoUno, Vehiculo vehiculoDos)
    {
      int retorno = 0;
      if(vehiculoUno.)
    }
  }
}
