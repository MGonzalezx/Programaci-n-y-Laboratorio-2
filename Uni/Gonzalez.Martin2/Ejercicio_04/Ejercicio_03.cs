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
        {   /* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
            Console.Title = "Ejercicio Nro 3";
            int numero;
            bool esPrimo = true;
            int i;
            int j;
            Console.Write("Ingrese su numero: ");
            numero = int.Parse(Console.ReadLine());
            //Iniciamos en 2 ya que 0 y 1 no son primos
            for ( i = 2; i <= numero; i++)
            {
                for ( j = 2; j <= numero; j++)
                {
                    //Por ejemplo si i es 4 y J es 2, se cumple que sean diferentes y que el resto sea 0
                    //Entonces no es primo
                    if (i != j && i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                    //Luego ocurre el break e I continua con el siguiente numero.
                    //Cuando J supera el numero ingresado, sale del for y sigue al siguiente if, en donde esPrimo es True y se escribe en la consola
                    
                }
                if (esPrimo)
                {   //el \t seria como hacer TAB entre numeros
                    Console.Write("\t" + i);
                }
                esPrimo = true;
                //En el caso que se cumpla (i != j && i % j == 0) y no es primo tengo que volver a poner esPrimo en TRUE al final del primer for
            }
            Console.ReadLine();


        }
    }
}
