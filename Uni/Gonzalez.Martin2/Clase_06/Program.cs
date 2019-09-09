using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_06.Entidades;

namespace Clase_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Paleta a = 6;
            Tempera b = new Tempera(ConsoleColor.Black, "marca", 6);
            
            //Paleta b = new Paleta(3);
            Console.WriteLine(b, a);

           

            Console.ReadLine();

        }
    }
}
