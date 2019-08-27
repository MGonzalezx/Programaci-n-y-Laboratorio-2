using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double numero, double numeroDos, string operacion)
        {
            string operadorAux = operacion;
            double retorno = 0;

            switch (operadorAux)
            {
                case "+":
                    retorno = numero + numeroDos;
                    Console.WriteLine("La suma es: {0}", retorno);
                    break;
                case "-":
                    retorno = numero - numeroDos;
                    Console.WriteLine("La resta es: {0}", retorno);
                    break;
                case "/":
                    Calculadora.Validar(numeroDos);

                    retorno = numero / numeroDos;
                    Console.WriteLine("La division es: {0}", retorno);
                    break;
                case "*":
                    retorno = numero * numeroDos;
                    Console.WriteLine("La multiplicacion es: {0}", retorno);
                    break;
            }
            return retorno;
        }

        private static bool Validar(double numeroDos)
        {
            if(numeroDos != 0)
            {
                return true;
            }else
            {
                Console.WriteLine("No se puede dividir por 0");
                return false;
            }
        }
    }
}
