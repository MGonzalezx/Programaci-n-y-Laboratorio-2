using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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


      //Persona p = new Persona(10, "MongoShades", "HasNoLimits", 32);
      //if (datos.AgregarPersona(p) == true)
      //{
      //  Console.WriteLine("Se agregó una persona");
      //}
      //else
      //{
      //  Console.WriteLine("No se pudo agregar la persona");
      //}

      //Persona p = new Persona(4, "Dudis", "Fludis", 20);
      //if(datos.ModificarPersona(p) == true)
      //{
      //  Console.WriteLine("Se modificò una persona");
      //}
      //else
      //  {
      //    Console.WriteLine("No se pudo modificar la persona");
      //  }


      //PARA ELIMINAR LA PERSONA
      //if (datos.EliminarPersona(2) == true)
      //{
      //  Console.WriteLine("Se eliminò una persona");
      //}
      //else
      //{
      //  Console.WriteLine("No se pudo eliminar la persona");
      //}

      //TRAERTABLAPERSONAS
      DataTable table;
      table = new DataTable();
      //table = datos.TraerTablaPersonas();
      ////DataRow representa una fila de datos de un DataTable
      ////table.rows obtiene la coleccion de filas que pertenecen a esta tabla
      
      //table.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"/Personas_esquema.xml");
      //table.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"/Personas_datos.xml");

      table.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"/Personas_datos.xml");
      table.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"/Personas_esquema.xml");
      foreach (DataRow fila in table.Rows)
      {
        for (int i = 0; i < table.Columns.Count; i++)
        {
          Console.WriteLine(fila[i]);
        }
      }

      Console.ReadLine();
    }
  }
}
