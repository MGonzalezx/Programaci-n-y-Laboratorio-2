using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
    private string _color;
    private string _marca;

    public string Color
    {
      get { return this._color; }
    }

    public string Marca
    {
      get { return this._marca; }
    }

    public Auto (string color, string marca)
    {
      this._color = color;
      this._marca = marca;
    }
    public static bool operator ==(Auto a, Auto b)
    {
      bool retorno = false;
      if ((a._marca.Equals(b._marca) && a._color.Equals(b._color)))
      {
        retorno = true;
      }
      return retorno;
    }
    public static bool operator !=(Auto a, Auto b)
    {
      return !(a == b);
    }
    public override bool Equals(object obj)
    {
      object retorno = (Auto)obj;
      if(retorno is Auto && retorno.Equals(this._marca) && retorno.Equals(this._color))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public override string ToString()
    {
      return this._marca + " " + this._color;
    }
  }
}
