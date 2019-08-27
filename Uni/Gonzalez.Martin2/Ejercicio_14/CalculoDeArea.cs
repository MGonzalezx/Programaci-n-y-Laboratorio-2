using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            numero = Math.Pow(numero, 2);
            return numero;
        }

       public static double CalcularTriangulo(double numero, double numeroDos)
        {
            double area;
            area = (numero * numeroDos) / 2;
            return area;
        }

        public static double CalcularCirculo(double numero)
        {
            double area;
            area = Math.PI * Math.Pow(numero, 2);
            return area;
        }

    }
}
