using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {/*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
          string DecimalBinario(double). Convierte un número de entero a binario.
          double BinarioDecimal(string). Convierte un número binario a entero.*/

            Console.Title = "Ejercicio Nro 13";

            double numero;
            string binario;
            Console.Write("Ingrese su numero: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine(Conversor.DecimalBinario(numero));
            Console.Write("Ingrese su numero binario: ");
            binario = Console.ReadLine();
            Console.WriteLine(Conversor.BinarioDecimal(binario));

            Console.ReadKey();
        }
    }
}
