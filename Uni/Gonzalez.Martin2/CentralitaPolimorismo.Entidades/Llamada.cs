using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorismo.Entidades
{
    public abstract class Llamada
    {
        #region Variables
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region Propiedades
        public abstract float CostoLlamada { get; }
        public float Duracion { get { return this._duracion; } }
        public string NroDestino { get { return this._nroDestino; } }
        public string NroOrigen { get { return this._nroOrigen; } }
        #endregion

        #region Metodos
        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
             //string value = "Numero de Origen: " + this._nroOrigen + " - Numero de Destino: " + this._nroDestino +
             //   " - Duracion: " + this._duracion.ToString() + "\n";
            StringBuilder retorno = new StringBuilder("Numero de Origen: " + this._nroOrigen + " - Numero de Destino: " + this._nroDestino +
                " - Duracion: " + this._duracion.ToString() + " \n");
            return retorno.ToString();
            
        }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int retorno;
            retorno = uno._duracion.CompareTo(dos._duracion);
            return retorno;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Llamada uno, Llamada dos)
        {
            bool retorno = false;
            if (uno.Equals(dos) && uno.NroOrigen == dos.NroOrigen && uno.NroDestino == dos.NroDestino)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
        #endregion

    }
}
