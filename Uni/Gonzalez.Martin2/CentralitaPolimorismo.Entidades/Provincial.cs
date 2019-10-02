using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorismo.Entidades
{
    public class Provincial : Llamada
    {
        #region Variables
        protected EFranja _franjaHoraria;
        #endregion

        #region Propiedades
        public override float CostoLlamada { get {return this.CalcularCosto();} }
        #endregion

        #region Constructores
        public Provincial(EFranja miFranja, Llamada unallamada) :this(unallamada.NroOrigen, miFranja, unallamada.Duracion,unallamada.NroDestino)
        {

        }

        public Provincial(string origen, EFranja miFranja, float duracion, string destino) : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        #endregion

        #region Metodos

        private float CalcularCosto()
        {
            float retorno = 0;
            if(this._franjaHoraria == EFranja.Franja_01)
            {
                 return retorno = base.Duracion * (float)0.99;
            }else if (this._franjaHoraria == EFranja.Franja_02)
            {
                 return retorno = base.Duracion * (float)1.25;
            }else if (this._franjaHoraria == EFranja.Franja_03)
            {
                 return retorno = base.Duracion * (float)0.66;
            }
            return retorno;
        }

        public override bool Equals(object obj)
        {

            if (obj is Provincial)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder costoLlamada = new StringBuilder("Franja Horaria: "+ this._franjaHoraria.ToString() +" - " 
                + "Costo llamada: " + this.CostoLlamada);
            return base.Mostrar() + costoLlamada + "\n";
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
