using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            int numero;
            int numeroAlCuadrado;
            int numeroAlCubo;
            //double numeroAlCuadrado;
            //double numeroAlCubo;

            Console.Write("Ingrese su numero: ");

            numero = int.Parse(Console.ReadLine());

           while(numero < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.Write("Reingrese su numero: ");

                numero = int.Parse(Console.ReadLine());
            }

            numeroAlCuadrado = (int) (Math.Pow(numero, 2));
            numeroAlCubo = (int) (Math.Pow(numero, 3));
            //numeroAlCuadrado = Math.Pow(numero, 2);
            //numeroAlCubo = Math.Pow(numero, 3);
            Console.WriteLine("El numero al cuadrado es: {0}", numeroAlCuadrado);
            Console.WriteLine("El numero al cubo es: {0}", numeroAlCubo);
      
            Console.ReadLine();
        }
    }
}
