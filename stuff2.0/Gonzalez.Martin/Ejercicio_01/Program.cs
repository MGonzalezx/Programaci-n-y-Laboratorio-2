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
            int acumulador;
            int mayor;
            int menor;
            float promedio;
            for(i=0; i<5; i++)
            {
               Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());

                acumulador = numero;
                if(i == 0)
                {
                    menor = numero;
                    mayor = numero;
                }
                else if (numero > mayor)
                {
                    numero = mayor;

                }
                else if (numero < menor)
                {
                    numero = menor;
                }

            }
            

            Console.ReadLine();
        }
    }
}
