using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
  public class Sello
  {
    public static string Mensaje;
    public static ConsoleColor color;
    

    public static string Imprimir()
    {
      return Sello.Mensaje; 
    }

    public static void Borrar()
    {
      Sello.Mensaje = "";
    }
    
    public static void ImprimirElColor()
    {
      Console.ForegroundColor = color;
      Console.WriteLine(Sello.Imprimir());
      Console.ResetColor();
    }
    private static string ArmarFormatoMensaje(Sello.)
    {

    }

  }
}
