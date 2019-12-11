using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        public bool deMetal;

        public Sacapunta():this(false,0,"vacio")
        {

        }

        public Sacapunta(bool deMetal, double precio, string marca) : base(marca,precio)
        {
            this.deMetal = deMetal;
        }

        public override bool PreciosCuidados => false;

        public override string ToString()
        {
            return base.ToString() + "De Metal" + this.deMetal;
        }
    }
}
