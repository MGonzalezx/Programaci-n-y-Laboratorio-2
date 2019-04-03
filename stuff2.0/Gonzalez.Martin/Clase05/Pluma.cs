using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
  public class Pluma
  {
    private string _Marca;
    private Tinta _Tinta;
    private int _cantidad;

    public Pluma() : this("Sin  Marca", null, 0)
    {

    }

    public Pluma(string a) : this(a, null, 0)
    {

    }

    public Pluma(string a, Tinta b) : this(a, b, 0)
    {

    }

    public Pluma(string a, Tinta b, int c)
    {
      this._Marca = a;
      this._Tinta = b;
      this._cantidad = c;
    }

    private string Mostrar()
    {
      return this._Marca + "-" + Tinta.Mostrar(this._Tinta) + "-" + this._cantidad.ToString();
    }

    public static bool operator ==(Pluma MiPluma, Tinta MiTinta)
    {
      return MiPluma._Tinta == MiTinta;
    }

    public static bool operator !=(Pluma MiPluma, Tinta MiTinta)
    {
      return !(MiPluma == MiTinta);
    }

    //public static implicit o explicit operator
    public static implicit operator string (Pluma p)
    {
      return p.Mostrar();
    }
    public static Pluma operator + (Pluma MiPluma, Tinta MiTinta)
    {
      if(MiPluma._Tinta == MiTinta)
      {
         return MiPluma._cantidad += 10
      }
      else
      {
        return
      }
    }
  }
}

