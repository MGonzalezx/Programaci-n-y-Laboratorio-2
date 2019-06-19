using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase21.Entidades;
using System.IO;


namespace Clase21.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Empleado empleado = new Empleado();
      empleado.limiteSueldo += new DelegadoSueldo(limiteSueldoEmpleado);
      empleado.limiteSueldo += new DelegadoSueldo(GuardarLog);
      empleado.Nombre = "Juan";
      empleado.Legajo = 123;
      empleado.Sueldo = 15000;

     


      Console.ReadKey();
    }
    private static void limiteSueldoEmpleado(Empleado e, float b)
    {
      Console.WriteLine(" Empleado: " + e.ToString() + " Sueldo asignado: " + b.ToString());
    }
      public static void GuardarLog(Empleado e, float b)
    {
      try
      {
   
          StreamWriter Archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\incidentes.log", true);
          Archivo.WriteLine(DateTime.Now.ToString() + " - " + e.Nombre + " - " + e.Legajo.ToString() + " - "  + b.ToString());
          Archivo.Close();
      }
      catch(Exception)
      {
        throw;
      }
      

    }
  }
}
