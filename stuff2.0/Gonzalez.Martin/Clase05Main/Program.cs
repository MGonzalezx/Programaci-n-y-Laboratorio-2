using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05;


namespace Clase05Main
{
   class Program
  {
    static void Main(string[] args)
    {
      Tinta obj1 = new Tinta();
      Tinta obj2 = new Tinta(ConsoleColor.DarkGray);
      Tinta obj3 = new Tinta(ConsoleColor.DarkBlue, ETipoTinta.ConBrillito);

      Console.WriteLine(obj1.Mostrar());
      Console.WriteLine(obj2.Mostrar());
      Console.WriteLine(obj3.Mostrar());
      Console.ReadKey();

      Pluma p1 = new Pluma();
      Pluma p2 = new Pluma("BIC", obj1, 12);
    }
  }
}
