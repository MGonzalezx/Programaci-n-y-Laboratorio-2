using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavadero;

namespace Lavadero.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto nuevoAuto = new Auto(4, "AAA111", EMarca.Fiat, 4);
            Auto nuevoDos = new Auto(5, "AAA222", EMarca.Ford, 6);
            Auto nuevoTres = new Auto(6, "AAA333", EMarca.Honda, 7);
            Camion nuevoCamion = new Camion(1000, "BBB444", EMarca.Iveco, 10);
            Lavadero lavadero = new Lavadero(50, 200, 25);
            lavadero += nuevoAuto;
            lavadero += nuevoCamion;
            lavadero += nuevoTres;
            lavadero += nuevoDos;
            List<Vehiculo> vehiculosLavadero = new List<Vehiculo>(lavadero.MisVehiculos);
            vehiculosLavadero.Sort(Lavadero.OrdenarVehiculosPorPatente);
            //Console.WriteLine(nuevoAuto.ToString());
            Console.WriteLine(lavadero.MiLavadero);
            Console.WriteLine("Total facturado:" + lavadero.MostrarTotalFacturado(EVehiculos.Auto).ToString());
            Console.WriteLine("");
            vehiculosLavadero.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
