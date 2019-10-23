using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public abstract class Auto : Vehiculo
    {
        #region Variables
        protected string _patente;
        #endregion

        #region Constructor
        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }
        #endregion

        #region Metodo
        public void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }
        #endregion
    }
}
