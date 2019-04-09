using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.entidades
{
    public class Tempera
    {
      private ConsoleColor _Color;
      private string _Marca;
      private sbyte _Cantidad;

    public Tempera(string marca, ConsoleColor color, sbyte cantidad)
    {
      this._Marca = marca;
      this._Color = color;
      this._Cantidad = cantidad;
    }

    private string Mostrar()
    { 
      return this._Marca + " - " + this._Color.ToString() + " - " + this._Cantidad;
    }

    public static string Mostrar(Tempera MiTempera)
    {
            return MiTempera.Mostrar();
    }

    public static bool operator ==(Tempera MiMarca, Tempera MiColor)
    {
      if(Tempera.Equals(MiMarca, null) && Tempera.Equals(MiColor, null))
            {
                return true;
            }
            else if((Tempera.Equals(MiMarca, null) && Tempera.Equals(MiColor, null) == false) || (Tempera.Equals(MiMarca, null) == false && Tempera.Equals(MiColor, null)))
            {
                return false;
            }
            return (MiMarca._Color == MiColor._Color && MiMarca._Marca.Equals(MiColor._Marca));
    }

    public static bool operator !=(Tempera MiMarca, Tempera MiColor)
    {
      return !(MiMarca == MiColor);
    }

    public static Tempera operator + (Tempera MiTempera, sbyte MiCantidad)
    {
            MiTempera._Cantidad += MiCantidad;
            return MiTempera;
    }

    public static Tempera operator +(Tempera MiTempera, Tempera MiTemperaDos)
        {
            if(MiTempera == MiTemperaDos)
            {
                MiTempera = MiTempera + MiTemperaDos._Cantidad;
            }
            return MiTempera;
        }

        public static implicit operator sbyte (Tempera Tempera)
        {
            return Tempera._Cantidad;
        }
  }
}
