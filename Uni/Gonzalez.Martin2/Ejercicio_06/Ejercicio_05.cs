using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {   /* Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.*/
            Console.Title = "Ejercicio Nro 5";

            double aumento = 1;
            double numero;
            double i;
            double j;
            double sumaAtras;
            double sumaAdelante;

            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());

            while (aumento < numero)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
                //calculo para adelante
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                {
                    Console.WriteLine("Es centro numerico: {0}", aumento);
                }
                    
            }
            Console.ReadLine();
        }
    }
}
