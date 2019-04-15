using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        //Valido los operadores
        private static string ValidarOperador(string operador)
        {
            //Equals por las dudas
            if(String.Equals(operador, "+") || String.Equals(operador, "-") || String.Equals(operador, "/") || String.Equals(operador, "*"))
            {
                return operador;
            }
            //Si no cumple con ninguno de esos, devuelve "+"
            return "+";
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            //Tiene que validar el operador que ingresamos, entonces llamamos a ValidarOperador
            string operadorAux = Calculadora.ValidarOperador(operador);
            double retorno = 0;
         
            
            //Dependiendo del operador hace un calculo, parecido al menu de opciones en C.
            switch (operadorAux)
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "/":
                    if(string.Equals(num2, 0))
                    {
                        retorno = Double.MinValue;
                    }
                    
                    retorno = num1 / num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
            }
            return retorno;
        }
    }
}
