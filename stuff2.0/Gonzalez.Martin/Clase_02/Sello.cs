using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
  public class Sello
  {
        public static string mensaje = "";
        public static ConsoleColor color;


        public static string Imprimir()
        {
            return ArmarFormatoMensaje(Sello.mensaje);
        }

        public static void Borrar()
        {
            Sello.mensaje = "";  
        }

        public static void ImprimirEnColor()
        {
            ConsoleColor colorAnterior = Console.ForegroundColor;
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = colorAnterior;
        }

        private static string ArmarFormatoMensaje(string nuevoMensaje)
        {
            string cadenaAsteriscos = "";

            if (nuevoMensaje.Length > 0)
            {
                for (int i = 0; i < nuevoMensaje.Length + 2; i++)
                {
                    cadenaAsteriscos += "*";
                }

                nuevoMensaje = cadenaAsteriscos + "\n*" + nuevoMensaje + "*\n" + cadenaAsteriscos;
            }
            return nuevoMensaje;
        }

    }
}
