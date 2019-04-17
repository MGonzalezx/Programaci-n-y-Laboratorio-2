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

    private Lavadero _lavadero;

    private string constructor
    {
      set { _lavadero = }
    }

    //public Lavadero MiLavadero
    //{
    //  get { return _lavadero; }
    //  //set { _lavadero = value; }
    //}

    public Lavadero(List<Vehiculo> vehiculos, float precioAuto, float precioCamion, float precioMoto)
    {
      this._vehiculos = vehiculos;
      this._precioAuto = precioAuto;
      this._precioMoto = precioMoto;
      this._precioCamion = precioCamion;
    }

  }
}
