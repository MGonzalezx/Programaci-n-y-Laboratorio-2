using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";

            int numero;
            int i;
            int j;
            int contador = 0;
            Console.Write("Ingrese su numero: ");

            numero = int.Parse(Console.ReadLine());

            for (i = 0; i < numero; i++)
            {
                for(j = 1; j <= i ; j++)
                {
                    if(i % j == 0)
                    {
                        contador++;
                    }
                }
            }
            
                Console.Write("contador {0}", contador);

            
            Console.ReadLine();
        }
    }
}
