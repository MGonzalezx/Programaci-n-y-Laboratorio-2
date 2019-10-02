using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaPolimorismo.Entidades;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central = new Centralita("Telefonica");
            Local local1 = new Local("001",30, "002" , (float)2.65);
            Provincial provincial1 = new Provincial("003", EFranja.Franja_01, 21, "004");
            Local local2 = new Local("005", 45, "006", (float)1.99);
            Provincial provincial2 = new Provincial(EFranja.Franja_03, provincial1);

            central += local1;
            central += provincial1;
            central += local2;
            central += provincial2;
            Console.WriteLine(central.ToString());
            Console.ReadLine();
        }
    }
}
