using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;

namespace Clase_04
{
    class Clase_04
    {
        static void Main(string[] args)
        {
            Cosa objeto = new Cosa();
            Cosa objeto2 = new Cosa("Hola");
            Cosa objeto3 = new Cosa("Chau", DateTime.Today);
            Cosa objeto4 = new Cosa("Bien", DateTime.Now, 10);

            Console.Write(objeto.Monstrar());
            Console.Write(objeto2.Monstrar());
            Console.Write(objeto3.Monstrar());
            Console.Write(objeto4.Monstrar());

            Console.ReadKey();

        }
    }
}
