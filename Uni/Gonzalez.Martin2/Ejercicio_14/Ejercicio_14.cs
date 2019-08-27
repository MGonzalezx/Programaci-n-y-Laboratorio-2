using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double numeroCuadrado;
            double numeroTriangulo;
            double numeroTrianguloDos;
            double numeroCirculo;

            Console.Write("Ingrese el Numero del cuadrado: ");
            numeroCuadrado = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el primer Numero del triangulo: ");
            numeroTriangulo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo Numero del triangulo: ");
            numeroTrianguloDos = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el Numero del circulo: ");
            numeroCirculo = double.Parse(Console.ReadLine());

            Console.WriteLine("El area del cuadrado es: {0}", CalculoDeArea.CalcularCuadrado(numeroCuadrado));
            Console.WriteLine("El area del triangulo es: {0}", CalculoDeArea.CalcularTriangulo(numeroTriangulo, numeroTrianguloDos));
            Console.WriteLine("El area del cuadrado es: {0}", CalculoDeArea.CalcularCirculo(numeroCirculo));

            Console.ReadKey();
        }
    }
}
