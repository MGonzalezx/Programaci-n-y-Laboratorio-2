using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Tempera
    {
      private ConsoleColor _Color;
      private string _Marca;
      private sbyte _Cantidad;

    public Tempera(string a, ConsoleColor b, sbyte c)
    {
      this._Marca = a;
      this._Color = b;
      this._Cantidad = c;
    }

    private string Mostrar()
    {
      return this._Marca + "-" + this._Color + "-" + this._Cantidad.ToString();
    }

    public static string Mostrar(Tempera MiTempera)
    {
      return MiTempera.Mostrar();
    }

    public static bool operator ==(Tempera MiMarca, Tempera MiColor)
    {
      return (MiMarca._Marca.Equals(MiColor));
    }

    public static bool operator !=(Tempera MiMarca, Tempera MiColor)
    {
      return !(MiMarca == MiColor);
    }

    public static Tempera operator + (Tempera MiTempera, sbyte MiCantidad)
    {
      return;
    }
  }
}
