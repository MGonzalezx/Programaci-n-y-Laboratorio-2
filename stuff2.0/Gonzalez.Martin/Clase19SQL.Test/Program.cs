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
      
      AccesoDatos datos = new AccesoDatos();
            //List<Persona> l = new List<Persona>();
            //l = datos.TraerTodos();

            //foreach (Persona item in l)
            //{
            //  Console.WriteLine(item.ToString());
            //}


            Persona p = new Persona(10, "Santiago", "Gonzalez", 40);
            if (datos.AgregarPersona(p) == true)
            {
                Console.WriteLine("Se agregó una persona");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la persona");
            }

            Console.ReadLine();
    }
  }
}
