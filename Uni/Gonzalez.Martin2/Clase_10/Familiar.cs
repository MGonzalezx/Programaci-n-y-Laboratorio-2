using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Familiar : Auto
    {
        #region Variables
        protected int _cantAsientos;
        #endregion

        #region Constructores
        public Familiar(double precio, string patente, int cantidadAsientos): base(precio, patente)
        {
            this._cantAsientos = cantidadAsientos;
        }
        #endregion
    }
}
