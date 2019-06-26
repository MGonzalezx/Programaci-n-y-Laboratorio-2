using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  public class Manzana : Fruta
  {
    protected string _provinciaDeOrigen;

    public string Nombre { get { return "Manzana" ; }  }


    public  Manzana (string color, double peso,string provincia) : base(color, peso)
    {
      this._provinciaDeOrigen = provincia;
    }

    public override bool TieneCarozo
    {
      get { return true; }
    }

    public override string ToString()
    {
      return base.ToString() + "- Nombre: " + this.Nombre +"- Provincia De Oringen: " + this._provinciaDeOrigen;
    }
  }
}
