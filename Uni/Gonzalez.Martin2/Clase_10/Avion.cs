using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Avion : Vehiculo,IAFIP,IARBA
    {
        #region Variables
        protected double _velocidadMaxima;
        #endregion

        #region Constructores
        public Avion(double precio, double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }
        #endregion

        #region Metodos
        public double CalcularImpuesto()
        {
            double impuesto = 0;
            impuesto = this._precio * 0.27;
            return impuesto;
        }
         double IARBA.CalcularImpuesto()
        {
            double impuesto = 0;
            impuesto = this._precio * 0.25;
            return impuesto;
        }
        #endregion
    }
}
