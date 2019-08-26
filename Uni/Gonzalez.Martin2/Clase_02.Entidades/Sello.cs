using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
           
            return Sello.ArmarFormatoMensaje();
             
        }

        public static void Borrar()
        {
            Sello.mensaje = " ";
        }

        public static void ImprimirEnColor()
        {
            ConsoleColor colorAnterior = Console.ForegroundColor;
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.ArmarFormatoMensaje());
            //Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = colorAnterior;
        }

        private static string ArmarFormatoMensaje()
        {
            int largoMensajeTecho = Sello.mensaje.Length + 2;
            int i;
            string techo = "";

            for (i = 0; i < largoMensajeTecho; i++)
            {
                techo += "*";
            }

            return techo + "\n" + "*" + Sello.mensaje + "*\n" + techo + "\n";
        }
    }
}
