using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Clase_03
    {
        static void Main(string[] args)
        {
            Persona miPersona = new Persona("Rudis", "Fludis", 78956431);
            
            /*miPersona.nombre = "Martin";
            miPersona.apellido = "Gonzalez";
            miPersona.dni = 87739104;*/

            Console.WriteLine(miPersona.Mostrar());

            Persona miPersona2 = new Persona("Mongo", "Shades", 12457896);

            /*Console.Write("Ingrese nombre: ");
            miPersona2.nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            miPersona2.apellido = Console.ReadLine();
            Console.Write("Ingrese dni: ");
            miPersona2.dni = int.Parse(Console.ReadLine());*/

            Console.WriteLine(miPersona2.Mostrar());

            Console.ReadKey();
        }
    }
}
