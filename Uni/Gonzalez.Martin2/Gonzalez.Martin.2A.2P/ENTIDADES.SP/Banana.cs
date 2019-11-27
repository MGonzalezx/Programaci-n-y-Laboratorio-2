using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public string Nombre { get { return "Banana"; } }

        public Banana(string color, double peso, string paisOrigen) : base(color, peso)
        {
            this._paisOrigen = paisOrigen;
        }

        public override bool TieneCarozo => false;

        public override string ToString()
        {
            return base.FrutaToString() + "Pais Origen: " + this._paisOrigen + "Tiene Carozo" + this.TieneCarozo;
        }
    }
}
