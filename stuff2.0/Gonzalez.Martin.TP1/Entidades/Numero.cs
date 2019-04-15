using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double _numero;
        
        //CONSTRUCTORES
        //Constructor sin parametros devuelve 0. Los constructores seran los llamados Numero mostrados en el diagrama
        public Numero() : this(0)
        {
        }
        public Numero(double numero)
        {
            _numero = numero;
        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        

        //METODOS

        //Crear ValidarNumero para usarlo en el SetNumero.
        private double ValidarNumero(string strNumero)
        {
            //Verifica que el numero recibido sea numerico, devuelve double, de lo contrario 0
            double auxiliar;
            //El numero que recibimos va a estar en string, pero tiene que verificar que sea numerico. TryParse devuelve el valor equivalente al numero escrito en string. 
            //Elegimos que devuelva en double
            if(!Double.TryParse(strNumero, out auxiliar))
                {
                //Si es falso, tiene que devolver 0, sino devuelve el numero  
                auxiliar = 0;
                }
            return auxiliar;
        }
        
            //SetNumero asignará un valor al atributo número, previa validación.En este lugar será el único en todo el código que llame al método ValidarNumero.
        private string SetNumero
        {
            set { _numero = this.ValidarNumero(value); }
        }
        //El método BinarioDecimal convertirá un número binario a decimal, en caso de ser posible.Caso contrario retornará "Valor inválido"
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";
            bool flag = true;
            int auxNumero;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != 1 || binario[i] != 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                auxNumero = Convert.ToInt32(binario, 10);
                retorno = auxNumero.ToString();
            }
            return retorno;
        }

        public static string DecimalBinario(double numero)
        {
            string retorno;
            int auxiliar;
            auxiliar = Convert.ToInt32(Math.Abs(numero));
            retorno = Convert.ToString(auxiliar, 2);
            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            double auxNumero;
            if (!Double.TryParse(numero, out auxNumero))
            {
                retorno = Numero.DecimalBinario(auxNumero);
            }
            return retorno;
        }

        //OPERADORES 
        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero / n2._numero;
        }
    }
}
