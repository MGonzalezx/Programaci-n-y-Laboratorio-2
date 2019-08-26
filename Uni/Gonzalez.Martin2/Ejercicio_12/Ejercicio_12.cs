using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {/*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
            un mensaje "¿Continuar? (S/N)".
            En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
            opciones.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
            cualquier otro valor. */

            Console.Title = "Ejercicio Nro 12";
            int numero;
            int suma = 0;
            char respuesta = ' ';
            Console.Write("Ingrese su numero: ");
            numero = int.Parse(Console.ReadLine());
            suma = suma + numero;
            Console.Write("¿Quiere seguir ingresando numeros? (S/N) ");
            respuesta = char.Parse(Console.ReadLine());
            ValidarRespuesta.ValidaS_N(respuesta);

            while (respuesta == 'S' || respuesta == 's')
            {
                Console.Write("Ingrese su numero: ");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                Console.Write("¿Quiere seguir ingresando numeros? (S/N) ");
                respuesta = char.Parse(Console.ReadLine());
                ValidarRespuesta.ValidaS_N(respuesta);
            }

            Console.WriteLine("La suma total es: {0}", suma);
            Console.ReadKey();


        }
    }
}
