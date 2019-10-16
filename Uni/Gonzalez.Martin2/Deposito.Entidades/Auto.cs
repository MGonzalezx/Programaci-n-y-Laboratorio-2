using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class Auto
    {
        #region Variables
        private string _color;
        private string _marca;
        #endregion

        #region Propiedades
        public string Color { get { return this._color; } }
        public string Marca { get { return this._marca; } }
        #endregion

        #region Constructores
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {

            if (obj is Auto && (Auto)obj == this)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Marca: " + this._marca + " - Color: " + this._color; 
        }

        #endregion

        #region Operadores
        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;
            if(a._color == b._color && a._marca == b._marca)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        #endregion

    }
}
