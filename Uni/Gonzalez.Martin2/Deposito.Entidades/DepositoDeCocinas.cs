using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class DepositoDeCocinas
    {
        #region Variables
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region Constructores
        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }
        #endregion

        #region Metodos
        private int GetIndice(Cocina a)
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

        public bool Agregar(Cocina a)
        {
            return this + a;
        }

        public bool Remover(Cocina a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string Cocina = " ";
            string DepositoCocina = " ";
            DepositoCocina = "Capacida Maxima: " + this._capacidadMaxima.ToString() + "\n" + "Listado De Cocinas:\n";
            foreach (Cocina cocinas in this._lista)
            {

                Cocina += cocinas.ToString() + "\n\n";

            }

            return DepositoCocina + Cocina;
        }
        #endregion

        #region Operadores
        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina a)
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
