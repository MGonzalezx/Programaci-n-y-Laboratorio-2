using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase04.entidades;

namespace Clase04
{
  class Program
  {
    static void Main(string[] args)
    {
      Cosa obj1 = new Cosa();
      Console.WriteLine(obj1.Mostrar());

      Cosa obj2 = new Cosa(8);
      Console.WriteLine(obj2.Mostrar());

      Cosa obj3 = new Cosa(7, DateTime.Now.AddDays(15));
      Console.WriteLine(obj3.Mostrar());

      Cosa obj4 = new Cosa(6, new DateTime(2018,12,9), "Hola");
      Console.WriteLine(obj4.Mostrar());

      Console.ReadLine();
    }
  }
}
