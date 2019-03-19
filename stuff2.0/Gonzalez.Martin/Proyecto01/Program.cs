using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hola Mundo");
            //System.Console.ReadLine();
            Console.Write("Ingrese nombre: ");
            string nombre;
            nombre = Console.ReadLine();
           
            Console.WriteLine("Su nombre es: {0}", nombre);
            Console.ReadLine();
        }
    }
}
