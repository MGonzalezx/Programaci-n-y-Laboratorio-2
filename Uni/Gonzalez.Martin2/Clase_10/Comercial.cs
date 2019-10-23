using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Comercial : Avion
    {
        #region Variables
        protected int _capacidadPasajeros;
        #endregion

        #region Constructores
        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }

        #endregion

    }
}
