using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  public class Durazno : Fruta
  {
    protected int _cantPelusa;

    public string Nombre { get { return "Durazno"; } }

    public Durazno( string color, double peso,int cantpelusa ) : base(color, peso)
    {
      this._cantPelusa = cantpelusa;
    }

    public override bool TieneCarozo
    {
      get { return true; }
    }

    public override string ToString()
    {
      return base.ToString() + "- Nombre: " + this.Nombre + "- Cantidad De Pelusa: " + this._cantPelusa;
    }
  }
}
