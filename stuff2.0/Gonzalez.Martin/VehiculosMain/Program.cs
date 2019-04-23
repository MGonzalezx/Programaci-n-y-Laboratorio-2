using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace VehiculosMain
{
  class Program
  {
    static void Main(string[] args)
    {
      Auto auto = new Auto(4, "AAA111", EMarca.Ferrari, 4);
      Moto moto = new Moto(3, "BBB222", EMarca.Renault, 2);
      Camion camion = new Camion(1000, "CCC333", EMarca.Scania, 10);
      List<Vehiculo> lista = new List<Vehiculo>();
      lista.Add(auto);
      lista.Add(moto);
      lista.Add(camion);

      //Console.WriteLine(auto.MostrarAuto());
      //Console.WriteLine(moto.MostrarMoto());
      //Console.WriteLine(camion.MostrarCamion());
      //Console.ReadKey();

      #region Con Polimorfismo
   foreach (Vehiculo item in lista)
    {
        Console.WriteLine(item.Mostrar()); 
    }
      Console.ReadLine();
    #endregion

    }
  }
}


