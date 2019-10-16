using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class DepositoGenerico<T>
    {
        #region Variables
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region Constructores
        public DepositoGenerico(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }
        #endregion

        #region Metodos
        private int GetIndice(T a)
        {
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string generico = " ";
            string DepositoGenerico = " ";
            DepositoGenerico = "Capacida Maxima: " + this._capacidadMaxima.ToString() + "\n" + "Listado De " 
                + typeof(T).Name + ":\n";
            foreach (T genericos in this._lista)
            {

                generico += genericos.ToString() + "\n";

            }

            return DepositoGenerico + generico;
        }
        #endregion

        #region Operadores
        public static bool operator +(DepositoGenerico<T> d, T a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator -(DepositoGenerico<T> d, T a)
        {
            int indice = d.GetIndice(a);
            bool retorno = false;
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                return retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
