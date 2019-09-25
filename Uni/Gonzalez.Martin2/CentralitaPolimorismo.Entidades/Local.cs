using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorismo.Entidades
{
    public class Local : Llamada
    {
        #region Variables
        protected float _costo;
        #endregion

        #region Propiedades
        public override float CostoLlamada { get {return this.CalcularCosto();} }
        #endregion

        #region Constructores
        public Local(Llamada unaLlamada, float costo) : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float retorno = base.Duracion * this._costo;

            return retorno;
        }

        public override bool Equals(object obj)
        {

            if (obj is Local)
            {
                return true;
                //return (Local)obj == this;
            }
            else
            {
                return false;
            }
        }
        
        protected override string Mostrar()
        {
            StringBuilder costoLlamada = new StringBuilder("Costo llamada: "+ this.CostoLlamada);
            return base.Mostrar() + costoLlamada;
        }

        public override string ToString()
        {
            return this.Mostrar(); 
        }
        #endregion
    }
}
