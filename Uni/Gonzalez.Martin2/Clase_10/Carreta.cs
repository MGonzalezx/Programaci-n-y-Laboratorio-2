using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio): base(precio)
        {

        }

        double IARBA.CalcularImpuesto()
        {
            double impuesto = 0;
            impuesto = this._precio * 0.18;
            return impuesto;
        }
    }
}
