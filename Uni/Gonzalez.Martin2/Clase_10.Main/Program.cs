using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_10;

namespace Clase_10.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Carreta car1 = new Carreta(100);
            Deportivo d1 = new Deportivo(100, "222BBB", 15000);
            Comercial c1 = new Comercial(100, 1000, 250);
            Avion a = new Avion(100, 2000);
            Privado p1 = new Privado(100, 2000, 50);

            Console.WriteLine("Carreta: ");
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(car1));
            Console.WriteLine("Auto: ");
            Console.WriteLine(Gestion.MostrarImpuestoNacional(d1));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(d1));
            Console.WriteLine("Avion Comercial: ");
            Console.WriteLine(Gestion.MostrarImpuestoNacional(a));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(a));
            Console.WriteLine("Avion Privado: ");
            Console.WriteLine(Gestion.MostrarImpuestoNacional(a));

            Console.ReadLine();
        }
    }
}
