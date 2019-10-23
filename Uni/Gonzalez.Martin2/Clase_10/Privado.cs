using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Privado : Avion
    {
        #region Variables
        protected int _valoraconServicioDeAbordo;
        #endregion

        #region Constructores
        public Privado(double precio, double velocidad, int valoracion) : base(precio, velocidad)
        {
            this._valoraconServicioDeAbordo = valoracion;
        }
        #endregion
    }
}
