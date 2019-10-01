using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorismo.Entidades
{
    public class Centralita
    {
        #region Variables
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion

        #region Propiedades
        public float GananciaPorLocal { get; }
        public float GananciaPorProvincial { get; }
        public float GananciaTotal { get; }
        public List<Llamada> Llamadas { get { return this._listaDeLlamadas; } }
        #endregion

        #region Constructores
        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            string telefono = " ";
            string empresa = " ";
            foreach (Llamada llamadas in this._listaDeLlamadas)
            {

                telefono += "Nro Origen: " + llamadas.NroOrigen.ToString() + " Nro Destino: " + llamadas.NroDestino.ToString() + " Duracion: " + llamadas.Duracion.ToString() + " Costo: " + llamadas.CostoLlamada.ToString() + "\n";

                //telefono += llamadas.NroOrigen.ToString() + " " + llamadas.NroDestino.ToString() + " " + llamadas.Duracion.ToString() + " " + llamadas.CostoLlamada.ToString() + "\n";
                empresa = "Nombre Empresa: " + this._razonSocial + "\n" + "Llamadas: " + telefono + "\n";
            }
            return empresa;
        }

        private void AgregarLlamada(Llamada llamadaNueva)
        {
            this._listaDeLlamadas.Add(llamadaNueva);
        }

        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada llamadas in this._listaDeLlamadas)
            {
                if (llamadas is Local)
                {
                    return ganancia += llamadas.CostoLlamada;

                }
                else if (llamadas is Provincial)
                {
                    return ganancia += llamadas.CostoLlamada;
                }
            }
            return ganancia;

        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort();
        }

        #endregion

        #region Operadores
        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retorno = false;
            foreach (Llamada auxllamada in central._listaDeLlamadas)
            {
                if (auxllamada == nuevaLlamada)
                {
                    return retorno = true;
                }
            }
            return retorno;

        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            //}else
            //{
            //   return "Llamada ya ingresada"

            //}
            return central;
        }
        #endregion
    }
}
