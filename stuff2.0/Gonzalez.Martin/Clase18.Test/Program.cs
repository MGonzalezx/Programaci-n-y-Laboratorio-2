using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Entidades.Clase18;

namespace Clase18.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Humano hum1 = new Humano();
      Persona per1 = new Persona("Juan", "Perez");
      Alumno alu1 = new Alumno();
      Profesor prf1 = new Profesor();

      alu1.Legajo = 12;
      hum1.Dni = 40749871;
      prf1.Titulo = "Medico";
      Console.ReadKey();

    }

    static bool SerializarAlumno(Alumno alumno)
    {
      try
      {
          XmlSerializer xmlSerializer = new XmlSerializer(typeof(Alumno));
          StreamWriter streamWriter = new StreamWriter(); 
          return true;
      }
      catch
      {

      }
      
      
    }
  }
}
