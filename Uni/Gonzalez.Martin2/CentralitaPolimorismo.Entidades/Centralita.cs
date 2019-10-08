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
        public float GananciaPorLocal { get { return this.CalcularGanancia(ETipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(ETipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(ETipoLlamada.Local) + this.CalcularGanancia(ETipoLlamada.Provincial); } }
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
            empresa = "Nombre Empresa: " + this._razonSocial + "\n" + "Llamadas:\n";
            foreach (Llamada llamadas in this._listaDeLlamadas)
            {

                telefono += llamadas.ToString() + "\n\n";

            }
            return empresa + telefono + "\n" + "Ganancia por Local: " + this.GananciaPorLocal.ToString()
                    + " Ganancial por Provincial: " + this.GananciaPorProvincial.ToString() + " Ganancia Total: " + this.GananciaTotal.ToString();
        }

        private void AgregarLlamada(Llamada llamadaNueva)
        {
            this._listaDeLlamadas.Add(llamadaNueva);
        }

        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float ganancia = 0;
            foreach (Llamada llamadas in this._listaDeLlamadas)
            {
                if (llamadas is Local)
                {
                    gananciaLocal += llamadas.CostoLlamada;

                }
                else if (llamadas is Provincial)
                {
                    gananciaProvincial += llamadas.CostoLlamada;
                }
            }
            if (tipo == ETipoLlamada.Local)
            {
                 ganancia += gananciaLocal;
            }
            else if (tipo == ETipoLlamada.Provincial)
            {
                 ganancia += gananciaProvincial;
            }
            else if (tipo == ETipoLlamada.Todas)
            {
                ganancia = gananciaProvincial + gananciaLocal;
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
