using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase14.Entidades;

namespace Clase14.Main
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Ingrese un numero:");
        int numero = ParseadoraDeEnteros.Parse(Console.ReadLine());
      }
      catch (ErrorParserException e)
      {
        Console.WriteLine(e.Message);
      }
      Console.ReadLine();
    }
  }
}
