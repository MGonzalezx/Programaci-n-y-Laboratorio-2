using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que imprima por pantalla una pirámide comola siguiente:
                *
                ***
                *****
                *******
                *********
            El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
            ejemplo anterior la altura ingresada fue de 5. */
            Console.Title = "Ejercicio Nro 9";
            int altura;
            int i;
            int j;
            Console.Write("Ingrese altura: ");
            altura = int.Parse(Console.ReadLine());

            for(i = 0; i <=altura; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
