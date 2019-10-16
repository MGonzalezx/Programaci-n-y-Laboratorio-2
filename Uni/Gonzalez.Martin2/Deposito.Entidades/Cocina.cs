using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class Cocina
    {
        #region Variables
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region Propiedades
        public int Codigo { get { return this._codigo; } }
        public bool EsIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }
        #endregion

        #region Constructores
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {

            if (obj is Cocina && (Cocina)obj == this)
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
            return "Codigo: " + this._codigo + " - Precio: " + this._precio.ToString() +
                " - Es Industrial:" + this._esIndustrial.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retorno = false;
            if(a._codigo == b._codigo)
            {
                return retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        #endregion
    }
}
