using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        #region Variables
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;
        #endregion

        #region Contructores
        public Pluma()
        {
            this._marca = "Sin Marca";
            this._tinta = null;
            this._cantidad = 0;
        }
        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }
        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this._tinta = tinta;
        }
        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this._cantidad = cantidad;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return "Marca: " + this._marca + " - Tinta: " + Tinta.Mostrar(this._tinta) + " - Cantidad: " + this._cantidad.ToString();
        }
        #endregion

        #region Operadores
        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            bool retorno = false;
            if (pluma._tinta == tinta)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            
            if (pluma._tinta == tinta && pluma._cantidad < 100)
            {
                
                    pluma._cantidad++;
 
            }
            return pluma;
        }
        #endregion
    }
}
