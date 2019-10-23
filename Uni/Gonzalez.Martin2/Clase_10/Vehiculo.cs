using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public abstract class Vehiculo
    {
        #region Variables
        protected double _precio;
        #endregion

        #region Constructor
        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        #endregion

        #region Metodos
        public void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio.ToString());
        }
        #endregion
    }
}
