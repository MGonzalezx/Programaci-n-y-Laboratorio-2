using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        public bool soloLapiz;


        public Goma():this(false,"vacio", 0)
        {

        }

        public Goma( bool soloLapiz, string marca, double precio) : base(marca, precio)
        {
            this.soloLapiz = soloLapiz;
        }

        public override bool PreciosCuidados => true;


        public override string ToString()
        {
            return base.ToString() + " Solo Lapiz: " + this.soloLapiz;
        }
    }
}
