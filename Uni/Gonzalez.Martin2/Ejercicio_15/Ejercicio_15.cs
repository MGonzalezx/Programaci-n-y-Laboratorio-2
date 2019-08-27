using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            double numeroUno;
            double numeroDos;
            string operacion;

            Console.Write("Ingrese Primer Numero: ");
            numeroUno = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el Segundo Numero: ");
            numeroDos = double.Parse(Console.ReadLine());
            Console.Write("Ingrese que operacion quiere hacer (+,-,/,*): ");
            operacion = Console.ReadLine();

            Calculadora.Calcular(numeroUno, numeroDos, operacion);


            Console.ReadKey();

        }
    }
}
