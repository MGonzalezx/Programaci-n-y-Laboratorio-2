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
            Sello.mensaje = "Hola";
            Sello.color = ConsoleColor.Magenta;
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Sello.ImprimirEnColor();
            Console.ReadKey();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();


        }
  }
}
