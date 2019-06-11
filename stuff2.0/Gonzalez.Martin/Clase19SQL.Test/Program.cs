using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase19SQL;

namespace Clase19SQL.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Persona> l = new List<Persona>();
      AccesoDatos datos = new AccesoDatos();
      l = datos.TraerTodos();

      foreach (Persona item in l)
      {
        Console.WriteLine(item.ToString());
      }
      Console.ReadLine();

      List<Persona> l2 = new List<Persona>();
      l2 = datos.AgregarPersona(p);

    }
  }
}
