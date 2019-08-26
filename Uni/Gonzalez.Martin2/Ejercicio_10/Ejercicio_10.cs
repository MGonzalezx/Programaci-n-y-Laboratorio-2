using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";
            int altura;
            int i;
            int j;
            int k;

            Console.Write("Ingrese altura: ");
            altura = int.Parse(Console.ReadLine());

            for (i = 1; i <= altura; i++)
            {   
                //Hago los espacios
                for ( k = 1; k <= (altura-i); k++)
                {
                    Console.Write(" ");
                }

                //Hago los *
                for (j = 1; j < i*2; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
