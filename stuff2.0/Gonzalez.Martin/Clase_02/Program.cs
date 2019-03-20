using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
  class Program
  {
    static void Main(string[] args)
    {
      Sello.Mensaje = "Mensaje: Hola";
      Console.WriteLine("{0}", Sello.Imprimir());
      Console.ReadLine();

      Sello.Borrar();
      Console.WriteLine("{0}", Sello.Imprimir());
      Console.ReadLine();

      Sello.Mensaje = "Mensaje: Hola";
      Sello.color = ConsoleColor.Magenta;
      Sello.ImprimirElColor();
      Console.ReadLine();

      Sello.Mensaje = "Mensaje: Hola";
      Console.WriteLine("{0}", Sello.Imprimir());
      Console.ReadLine();


    }
  }
}
