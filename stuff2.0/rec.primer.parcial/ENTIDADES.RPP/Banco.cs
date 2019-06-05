using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
  public abstract class Banco
  {
    protected string _nombre;

    public Banco(string nombre)
    {
      this._nombre = nombre;
    }
  }
}
