using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {   /* Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
            también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. */
            Console.Title = "Ejercicio Nro 6";

            int primerAño;
            int segundoAño;
            int i;

            Console.Write("Ingrese primer año: ");
            primerAño = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo año: ");
            segundoAño = int.Parse(Console.ReadLine());

            for(i = primerAño; i < segundoAño; i++)
            {
                if( i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine("El año " + i + "es bisiesto");
                }
            }
            Console.ReadLine();
        }
    }
}
