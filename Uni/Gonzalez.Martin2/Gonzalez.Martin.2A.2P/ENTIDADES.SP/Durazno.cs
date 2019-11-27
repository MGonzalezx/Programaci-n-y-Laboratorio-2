using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public string Nombre { get { return "Durazno"; } }

        public Durazno(string color, double peso, int cantPelusa) : base(color, peso)
        {
            this._cantPelusa = cantPelusa;
        }

        public override bool TieneCarozo => true;

        public override string ToString()
        {
            return base.FrutaToString() + "Cantidad Pelusa: " + this._cantPelusa + "Tiene Carozo" + this.TieneCarozo;
        }
    }
}
