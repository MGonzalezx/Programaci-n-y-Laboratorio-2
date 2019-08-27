using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Validacion
    {

        public static bool Validar(int valor, int min, int max)
        {
           bool retorno = true;
           if (valor >= -100 && valor <= 100)
            //if (Enumerable.Range(-100, 100).Contains(valor))
            {
                return retorno;
            }
            else
            {
                retorno = false;
                while (valor < -100 || valor > 100)
                {
                    Console.WriteLine("Su numero no esta entre el rango de -100 y 100");
                    Console.Write("Reingrese su Numero: ");
                    valor = int.Parse(Console.ReadLine());
                }
                return retorno;

            }

        }
    }
}
