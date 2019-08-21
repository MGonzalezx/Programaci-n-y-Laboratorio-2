using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_02.Entidades;

namespace Clase_02
{
    class Clase_02
    {
        static void Main(string[] args)
        {
            /* MiClase.edad = 23;
             MiClase.nombre = "Martin";
             MiLibreria.MiClase.nombre = "Martin"; 
             MiClase.MostrarEdad();
             Console.WriteLine("Nombre: {0}",MiClase.RetornarNombre());
             Console.WriteLine("Nombre con libreria de clases: {0}", MiLibreria.MiClase.RetornarNombre());
             Console.WriteLine("¿Son los nombres iguales? {0}", MiClase.CompararNombres("Martin"));*/
            Sello.mensaje = "Hola mundo";
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Sello.mensaje = "HOLA";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Sello.mensaje = "CHAU";
            Console.WriteLine(Sello.Imprimir());


            Console.ReadLine();
        }
    }
}
