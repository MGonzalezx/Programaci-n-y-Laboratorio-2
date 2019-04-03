using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    public class Tinta
    {
    private ConsoleColor _color;
    private ETipoTinta _tipoTinta;

    public Tinta() : this(ConsoleColor.Black, ETipoTinta.Comun)
    {
      //this._color = ConsoleColor.Black;
      //this._tipoTinta = ETipoTinta.Comun;
    }

    public Tinta(ConsoleColor a) : this(a, ETipoTinta.Comun)
    {
    
    }

    public Tinta(ConsoleColor a, ETipoTinta b) 
    {
      this._color = a;
      this._tipoTinta = b;
    }

    public string Mostrar()
    {
      return this._color.ToString() + "-" + this._tipoTinta;
    }

     public static string Mostrar(Tinta tipoTinta)
    {
      return tipoTinta.Mostrar();
    }

  }
}
