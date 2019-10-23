using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        #region Variables
        protected int _caballosFuerza;
        #endregion

        #region Constructores
        public Deportivo(double precio, string patente, int hp): base(precio, patente)
        {
            this._caballosFuerza = hp;
        }
        #endregion

        #region Metodos
        public double CalcularImpuesto()
        {
            double impuesto = 0;
            impuesto = this._precio * 0.28;
            return impuesto;
        }

         double IARBA.CalcularImpuesto()
        {
            double impuesto = 0;
            impuesto = this._precio * 0.23;
            return impuesto;
        }
        #endregion
    }
}
