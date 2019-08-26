using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string retorno;
            int auxiliar;
            auxiliar = Convert.ToInt32(Math.Abs(numero));
            retorno = Convert.ToString(auxiliar, 2);
            return retorno;
        }

        public static double BinarioDecimal(string binario)
        {
            int exponente = binario.Length - 1;
            int NumeroDecimal = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (int.Parse(binario.Substring(i, 1)) == 1)
                {
                    NumeroDecimal = NumeroDecimal + int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return NumeroDecimal;
        }
    }
}
