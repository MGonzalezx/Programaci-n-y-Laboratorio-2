using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class DepositoDeAutos
    {
        #region Variables
        private int _capacidadMaxima;
        private  List<Auto> _lista;
        #endregion

        #region Constructores
        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }
        #endregion

        #region Metodos
        private int GetIndice(Auto a)
        {
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Agregar(Auto a)
        {
             return this + a ;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string Auto = " ";
            string DepositoDeAuto = " ";
            DepositoDeAuto = "Capacida Maxima: " + this._capacidadMaxima.ToString() + "\n" + "Listado De Autos:\n";
            foreach (Auto autos in this._lista)
            {

                Auto += autos.ToString() + "\n\n";

            }

            return DepositoDeAuto + Auto; 
        }
        #endregion

        #region Operadores
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            int indice = d.GetIndice(a);
            bool retorno = false;
            if(indice != -1)
            {
                d._lista.RemoveAt(indice);
                return retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
