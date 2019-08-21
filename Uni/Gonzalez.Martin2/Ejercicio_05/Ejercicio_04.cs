using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            /* Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.*/ 
            Console.Title = "Ejercicio Nro 4";
            int i; //Los numeros que vamos a verificar
            int j; //Vamos a dividir i con los numeros de J
            Console.WriteLine("Numeros perfectos: ");
            for (i = 1; i < 10000; i++)
            {
                int suma = 0;
                j = 1;
                while(j < i)
                {
                    if(i % j == 0)
                    {
                        
                        suma = suma + j;   
                    }
                    j++;
                }
                //Despues de verificar todos los divisores j que dan resto 0, vemos si la suma es igual al numero donde esta parado i
                if(suma == i)
                {
                  //Si es igual al numero donde esta parado i, se mostrará en consola
                    Console.Write("\t" + i);
                }
            }
            Console.ReadLine();
        }
    }
}
