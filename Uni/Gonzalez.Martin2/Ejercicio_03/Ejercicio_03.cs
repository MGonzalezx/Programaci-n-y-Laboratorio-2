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
      Console.Title = "Ejercicio Nro 3";
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
