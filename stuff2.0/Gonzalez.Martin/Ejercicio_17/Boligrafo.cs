using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
  class Boligrafo
  {

    private ConsoleColor color;
    private short tinta;
    public const short cantidadTintaMaxima = 100;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.color = color;
      this.tinta = tinta;
    }
      public ConsoleColor GetColor()
    {
      return Console.ForegroundColor = color;
    }

    public short GetTinta()
    {
      return tinta;
    }

    private void SetTinta(short tinta)
    {

    }
  }
}
