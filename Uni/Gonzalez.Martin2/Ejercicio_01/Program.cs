using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio de Bienvenida";
      Console.ForegroundColor = ConsoleColor.Red;
      Console.BackgroundColor = ConsoleColor.White;
      Console.WriteLine("Hola mundo C#");
      string nombre = "Martin";
      string apellido = "Gonzalez";
      Console.WriteLine("Mi nombre es: {0}, {1}", nombre, apellido);
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.BackgroundColor = ConsoleColor.Gray; 
      Console.Write("Ingrese edad: ");
      string edad;
      edad = Console.ReadLine();
      Console.WriteLine("Mi edad es: {0}", edad);
      Console.ReadLine();

    }
  }
}
