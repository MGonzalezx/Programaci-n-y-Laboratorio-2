using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public static bool operator + (DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            if(d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Cocina c)
        {
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool operator - (DepositoDeCocinas d, Cocina c)
        {
            if(d.GetIndice(c) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(c));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Agregar (Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            string cadena;
            cadena = "Capacidad maxima: " + this._capacidadMaxima + "\n";
            cadena += "Listado de Cocinas: \n";
            foreach (Cocina a in this._lista)
            {
                cadena += a.ToString();
            }
            return cadena;
        }
    }
}
