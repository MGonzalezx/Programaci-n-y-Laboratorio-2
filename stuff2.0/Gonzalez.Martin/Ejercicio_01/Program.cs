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
        {
            Console.Title = "Ejercicio_01";
            int numero;
            int i;
            int acumulador = 0;
            int mayor = 0;
            int menor = 0;
            float promedio;
            for(i=0; i<5; i++)
            {
               Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());

                acumulador = acumulador + numero;
                if(i == 0)
                {
                    menor = numero;
                    mayor = numero;
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

            promedio = (float) (acumulador / 5d);
            Console.WriteLine("Su numero Mayor es: {0}", mayor);
            Console.WriteLine("Su numero Menor es: {0}", menor);
            Console.WriteLine("Su Promedio es: {0:#,###.00}", promedio);

            Console.ReadLine();
        }
    }
}
