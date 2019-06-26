using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  public class Banana :Fruta
  {
    protected string _paisDeOrigen;

    public string Nombre { get { return "Banana"; } }

    public Banana( string color, double peso, string pais) : base(color, peso)
    {
      this._paisDeOrigen = pais;
    }

    public override bool TieneCarozo
    {
      get { return false; }
    }
    public override string ToString()
    {
      return base.ToString() + "- Nombre: " + this.Nombre + "- Pais De Oringen: " + this._paisDeOrigen;
    }
  }
}
