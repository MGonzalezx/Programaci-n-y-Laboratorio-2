using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase06.entidades;

namespace Clase06.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera nuevaTempera = new Tempera("Bic", ConsoleColor.DarkMagenta, 15);
            Tempera nuevaTemperaDos = new Tempera("Tintita", ConsoleColor.DarkCyan, 5);
            Tempera nuevaTemperaTres = new Tempera("Explota", ConsoleColor.Red, 8);
            Paleta nuevaPaleta = 2; //Cantidad maxima que se va a mostrar
            nuevaPaleta = nuevaPaleta + nuevaTempera;
            nuevaPaleta = nuevaPaleta + nuevaTemperaDos;
            nuevaPaleta = nuevaPaleta + nuevaTemperaTres;
            Console.WriteLine((string)nuevaPaleta);
            Console.ReadKey();
        }
    }
}
