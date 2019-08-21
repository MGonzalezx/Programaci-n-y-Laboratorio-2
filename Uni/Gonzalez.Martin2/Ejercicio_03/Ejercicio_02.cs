using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
  class Ejercicio_02
  {
    static void Main(string[] args)
    {
      /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
      mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
      Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. */
      Console.Title = "Ejercicio Nro 2";
      float cuadrado;
      float cubo;
      float numero;
      Console.WriteLine("Ingrese su numero: ");
       numero = float.Parse(Console.ReadLine());
      while(numero == 0)
      {
        Console.WriteLine("ERROR. ¡Reingresar número!");
        numero = float.Parse(Console.ReadLine());
      }
      cuadrado = (float) Math.Pow(numero, 2);
      cubo = (float)Math.Pow(numero, 3);
      Console.WriteLine("El numero al cuadrado es: {0}", cuadrado);
      Console.WriteLine("El numero al cubo es: {0}", cubo);
      Console.ReadLine();
    }
  }
}
