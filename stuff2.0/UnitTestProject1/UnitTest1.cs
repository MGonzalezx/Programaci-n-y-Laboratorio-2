using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    { //Assert posee varios metodos estaticos (de clase) que me permite hacer varias evaluaciones. True, false, etc.
      Estacionamiento estacionamiento = new Estacionamiento(10);
      //Verificamos que no sea nulo el espacio del estacionamiento
      Assert.IsNotNull(estacionamiento.Autos);
    }
    [TestMethod]
    public void EspacioEstacionamientoIncorrecto()
    {
      Estacionamiento a = new Estacionamiento(101);
      Estacionamiento b = new Estacionamiento(0);
      if (a.EspacioDisponible != 101)
      {
        Assert.Fail("Espacio incorrecto {0} ", a.EspacioDisponible);
      }
      //Tendria que fallar si hago un estacionamiento con 0 y comparo con 0.
      //0 no es igual a 1 asi que tendria que pasar
      Assert.AreNotEqual(b.EspacioDisponible, 1);
      if (b.EspacioDisponible != 0)
      {
        Assert.Fail("Espacio incorrecto {0} ", b.EspacioDisponible);
      }
    }
    [TestMethod]
    public void AgregarAutoEstacionamiento()
    {
      Estacionamiento c = new Estacionamiento(2);
      Auto ferari = new Auto("AAA111", ConsoleColor.Black);
      Auto audi = new Auto("BBB222", ConsoleColor.White);
      Auto toyota = new Auto("CCC333", ConsoleColor.Magenta);

      try
      {
        c += ferari;
        c += audi;
        c += toyota;
        Assert.Fail("No se pudo agregar 3 autos, solo se permite 2");
      }
      catch(Exception algo)
      {
        Assert.IsInstanceOfType(algo, typeof(EstacionamientoLlenoException));
      }
    }
    [TestMethod]
    public void AgregarAutoEspacioDisponible()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto ferari = new Auto("AAA111", ConsoleColor.Black);
      Auto audi = new Auto("BBB222", ConsoleColor.White);

      e += ferari;
      Assert.AreEqual(e.EspacioDisponible , 1);
      e += audi;
      Assert.AreEqual(e.EspacioDisponible , 0 );
    }

  }
}
