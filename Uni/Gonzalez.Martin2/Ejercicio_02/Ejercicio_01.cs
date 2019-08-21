using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {/*Ingresar 5 n�meros por consola, guard�ndolos en una variable escalar. Luego calcular y mostrar: el
          valor m�ximo, el valor m�nimo y el promedio.*/

            Console.Title = "Ejercicio Nro 1";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
            int i;
            float numero;
            float acumulador = 0;
            float mayor = 0;
            float menor = 0;
            float promedio;
            Console.WriteLine("Ingrese sus 5 numeros: ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Numero {0}: ", i + 1);
                numero = float.Parse(Console.ReadLine());

                acumulador = acumulador + numero;

                if (i == 0)
                {
                    mayor = numero;
                    menor = numero;
                }
                if (numero > mayor)
                {
                    mayor = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }

            }

            promedio = acumulador / i;
            Console.WriteLine("Su numero mayor es: {0}", mayor);
            Console.WriteLine("Su numero menor es: {0}", menor);
            Console.WriteLine("Su promedio es: {0:#,###.00}", promedio);
            Console.ReadLine();
        }
    }
}
