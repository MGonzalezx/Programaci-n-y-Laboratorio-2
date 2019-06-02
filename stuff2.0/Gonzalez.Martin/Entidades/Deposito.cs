using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(T d)
        {
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(d))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool operator - (Deposito<T> d, T a)
        {
            if (d.GetIndice(a) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(a));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T b)
        {
            return this - b;
        }

        public override string ToString()
        {
            string cadena;
            cadena = "Capacidad maxima: " + this._capacidadMaxima + "\n";
            cadena += "Listado de " + typeof(T).Name + ": \n";
            foreach (T objeto in this._lista)
            {
                cadena += objeto.ToString();
            }
            return cadena;
        }
    }
}
