using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {/*Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
           siguiente firma: bool Validar(int valor, int min, int max):
           a. valor: dato a validar
           b. min y max: rango en el cual deberá estar la variable valor.
           Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
           anteriormente que esten dentro del rango -100 y 100.
           Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. */
            Console.Title = "Ejercicio Nro 11";
            int numero;
            int i;
            int acumulador = 0;
            float mayor = 0;
            float menor = 0;
            float promedio;

            Console.WriteLine("Ingrese sus 10 numeros: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Numero {0}: ", i + 1);
                numero = int.Parse(Console.ReadLine());

                Validacion.Validar(numero, -100, 100);

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
            Console.ReadKey();
        }
    }
}
